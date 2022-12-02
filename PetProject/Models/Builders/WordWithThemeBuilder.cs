using PetProject.NewWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Models.Builders
{
    internal class WordWithThemeBuilder : IWordBuilder
    {
        public Theme Theme => theme;
        private Theme theme;
        private NewWordBuilder builder = new NewWordBuilder();
        public WordWithThemeBuilder(Theme theme)
        {
            this.theme = theme;
        }
        public Word Build(TranslatedWord translatedWord)
        {
            Word word = builder.Build(translatedWord);
            word.Theme = theme;
            return word;
        }
    }
}