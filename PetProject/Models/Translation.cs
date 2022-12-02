using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Models
{
    class Translation
    {
        public string TranslationText { get; set; }
        public List<Word> Words { get; set; } = new List<Word>();
        public Translation() { }
        public Translation(Word word, string translation)
        {
            Words.Add(word);
            TranslationText = translation;
        }
    }
}