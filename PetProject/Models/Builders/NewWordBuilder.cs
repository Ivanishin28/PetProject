using PetProject.NewWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Models.Builders
{
    internal class NewWordBuilder : IWordBuilder
    {
        public Word Build(TranslatedWord translatedWord)
        {
            Word word = new Word();
            word.WordText = translatedWord.Word;
            word.Info = translatedWord.Info;
            foreach(var translationText in translatedWord.Translations)
            {
                Translation translation = new Translation(word, translationText);
                word.Translations.Add(translation);
            }
            return word;
        }
    }
}