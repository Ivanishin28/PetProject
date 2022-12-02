using PetProject.Models;
using PetProject.NewWord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetProject.EF;
using Microsoft.EntityFrameworkCore;
using PetProject.Models.Builders;

namespace PetProject.Forms
{
    public partial class NewWordForm : Form
    {
        private PetContext context;
        public NewWordForm()
        {
            context = new PetContext();
            InitializeComponent();
        }

        private void NewWordForm_Load(object sender, EventArgs e)
        {
            languageBox.Items.Clear();

            string[] languages = context
                   .Languages
                   .OrderBy(l => l.Name)
                   .Select(l => l.Name)
                   .ToArray();
            languageBox.Items.AddRange(languages);
            languageBox.SelectedIndex = 0;
        }
        private void trunslateButton_Click(object sender, EventArgs e)
        {
            if (!ChooseLanguage(out Language language))
            {
                return;
            }
            listBox1.Items.Clear();
            ChooseTheme(out Theme theme);

            WordWithThemeBuilder builder = new WordWithThemeBuilder(theme);
            Facade facade = Facade.Factory.Facade(builder, language);

            var words = facade.CreateWords(richTextBox1.Text)?.ToList();
            
            if(words == null)
            {
                foreach(var er in facade.Errors)
                {
                    listBox1.Items.Add($"{er}");
                }
                return;
            }
            foreach(var word in words)
            {
                listBox1.Items.Add(word.ToString());
                var wordDB = context
                    .Words
                        .Include(w => w.Translations)
                        .FirstOrDefault(w => w.WordText == word.WordText);
                if(wordDB == null)
                {
                    continue;
                }
                //We should ensure EF knows about word's theme and language
                context.Entry(wordDB).Reference(w => w.Language).Load();
                context.Entry(wordDB).Reference(w => w.Theme).Load();
                
                //To exclude it from inserting. Thus SaveChanges will update the wordDB
                words.Remove(word);
                
                var newTranslations = word
                    .Translations
                    .Where(t => !wordDB.Translations.Contains(t));

                wordDB.Translations.AddRange(newTranslations);
            }
            context.Words.AddRange(words);
            context.SaveChanges();
        }
        private bool ChooseLanguage(out Language language)
        {
            string text = languageBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                language = null;
                return false;
            }
            language = context.Languages.Find(text);
            if (language == null)
            {
                language = new Language() { Name = text };
            }
            return true;
        }
        private void ChooseTheme(out Theme theme)
        {
            string text = themeBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                theme = null;
                return;
            }
            theme = null;
            /*theme = context.Themes.Find(text);
            if(theme == null)
            {
                theme = new Theme { ThemeName = text };
            }*/
        }
        private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void NewWordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void themeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}