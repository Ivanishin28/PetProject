using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetProject.Builders;
using PetProject.Models;
using PetProject.Models.Builders;
using PetProject.Validation;

namespace PetProject.NewWord
{
    class Facade : IValidationMediator
    {
        public Language Language => language;
        public bool HasErrors => translator.HasErrors;
        public List<ValidationErrorUnit> Errors => translator.Errors;
        private Language language;
        private Translator translator;
        private IWordBuilder builder;
        private Facade() { }
        public static class Factory
        {
            public static Facade Facade(IWordBuilder builder, Language language)
            {
                Facade facade = new Facade();
                facade.builder = builder;
                facade.language = language;
                facade.translator = new NewTranslator();
                return facade;
            }
            public static Facade Facade
                (IWordBuilder builder, Translator translator, Language language)
            {
                Facade facade = new Facade();
                facade.builder = builder;
                facade.language = language;
                facade.translator = new NewTranslator();
                return facade;
            }
        }
        public void ChangeLanguage(Language language)
        {
            this.language = language;
        }
        private IEnumerable<TranslatedWord> GetTranslatedWords(IEnumerable<string> source)
        {
            int i = 1;
            foreach(var line in source)
            {
                yield return translator.TranslateWithIndex(i++, line);
            }
        }
        private IEnumerable<Word> GetWords(IEnumerable<TranslatedWord> source)
        {
            foreach(var translatedWord in source)
            {
                Word word =  builder.Build(translatedWord);
                word.Language = Language;
                yield return word;
            }
        }
        public IEnumerable<Word> CreateWords(string text)
        {
            IEnumerable<string> source = text.Split('\n');
            IEnumerable<TranslatedWord> translatedWords 
                = GetTranslatedWords(source).ToList();
            if (this.HasErrors)
            {
                return null;
            }
            IEnumerable<Word> words = GetWords(translatedWords);
            return words;
        }
    }
}