using PetProject.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PetProject.Models
{
    class Word
    {
        public int WordId { get; set; }
        public string WordText { get; set; }
        public Language Language { get; set; }
        public string Info { get; set; }
        public List<Translation> Translations { get; set; } = new List<Translation>();
        [DataType(DataType.Date)]
        public string? ThemeId { get; set; }
        public int TranslationsCount => Translations.Count;
        public Theme Theme { get; set; }

#warning delete!!!
        /*public int WordInfoId { get; set; }
        public WordInfo WordInfo { get; set; }*/

        public DateTime AddedDate { get; set; } = DateTime.Now.Date;
        public bool ContainsTranslation(Translation translation)
        {
            foreach(var t in Translations)
            {
                if(t.TranslationText == translation.TranslationText)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(WordText);
            sb.Append($" [{Info}]: ");
            foreach(var t in Translations)
            {
                sb.Append($"{t.TranslationText}");
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}