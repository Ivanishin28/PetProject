using Microsoft.EntityFrameworkCore;
using PetProject.Dtos;
using PetProject.EF;
using PetProject.Filtering;
using PetProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetProject.EF;
using DateSpecType = PetProject.Filtering.DateSpecification.DateSpecType;
namespace PetProject.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            context = new PetContext();
            Program.MainForm = this;
            Program.NewWordForm = new NewWordForm();
            InitializeComponent();
        }
        PetContext context;
        Language language;
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] languages = context
                   .Languages
                   .OrderBy(l => l.Name)
                   .Select(l => l.Name)
                   .ToArray();
            languageBox.Items.AddRange(languages);
            languageBox.SelectedIndex = 0;
        }
        private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = languageBox.Text;
            language = context
                .Languages
                .SingleOrDefault(l => l.Name == selectedLanguage);
            if(language == null)
            {
                MessageBox.Show("Error");
                return;
            }
        }
        private async void browseButton_Click(object sender, EventArgs e)
        {
            if(language == null)
            {
                return;
            }

            CreateOrderByQuery(out OrderWordDtoQuery orderByQuery);       
            ISpecification<Word> specification = CreateWordSpecification();

            List<WordDto> words = null;
            /*await Task.Factory.StartNew(() =>
            {
                words = context
                .Words
                .AsNoTracking()
                .Include(w => w.Language)
                .Include(w => w.Translations)
                .Where(w => w.Language.Name == language.Name)
                .Where(specification.IsSatisfied)
                .MapWordToDto()
                .OrderWordDto(orderByQuery)
                .ToList();
            });*/
            await Task.Factory.StartNew(() =>
            {
                words =
                PetContext.GetFilteredWords(context, specification)
                .MapWordToDto()
                .OrderWordDto(orderByQuery)
                .ToList();
            });

            dataTable.DataSource = words
                .Select(w => new
                {
                    w.WordText,
                    w.Info,
                    w.TranslationsString,
                    w.AddedDate
                })
                .ToList();
        }
        private ISpecification<Word> CreateWordSpecification()
        {
            ComposedSpecification<Word> specification =
                new ComposedSpecification<Word>();

            LanguageSpecification langSpec
                = new LanguageSpecification(language);
            specification.AddSpecification(langSpec);

            if (afterDTPCheckBox.Checked)
            {
                DateSpecification afterSpecification =
                    new DateSpecification(afterDTP.Value, DateSpecType.After);
                specification.AddSpecification(afterSpecification);
            }

            if (beforeDTPCheckBox.Checked)
            {
                DateSpecification beforeSpecification =
                    new DateSpecification(beforeDTP.Value, DateSpecType.Before);
                specification.AddSpecification(beforeSpecification);
            }

            return specification;
        }

        private void CreateOrderByQuery(out OrderWordDtoQuery query)
        {
            OrderingType orderingType = OrderingType.WordText;
            if (obAddedDateRB.Checked)
            {
                orderingType = OrderingType.AddedDate;
            }
            else if(obTranslationNumberRB.Checked)
            {
                orderingType = OrderingType.TranslationsNumber;
            }
            query = new OrderWordDtoQuery(orderingType, isDescendingCB.Checked);
        }

        private void beforeDTPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            beforeDTP.Enabled = beforeDTPCheckBox.Checked;
        }

        private void afterDTPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            afterDTP.Enabled = afterDTPCheckBox.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.NewWordForm.ShowDialog();
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            Word w;
            using(var db = new PetContext())
            {
                w = db.Words
                    .Include(w => w.Language)
                    .Include(w => w.Translations)
                    .First();

                var we = db.Entry(w);
                db.ChangeTracker.TrackGraph(we, e =>
                {
                    e.Entry.Property("WordText").IsModified = true;
                });
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {/*
            List<TestingDto> words = null;
            ISpecification<Word> specification = CreateWordSpecification();
            await Task.Factory.StartNew(() =>
            {
                words = PetContext
                    .GetFilteredWords(context, specification)
                    .MapWordToTesting()
                    .ToList();
            });
            TestingForm testingForm = new TestingForm(words);
            testingForm.ShowDialog();*/
        }
    }
}