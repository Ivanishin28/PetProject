using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetProject.Models;
namespace PetProject.Builders
{
    abstract class WordBuilder<TSelf> 
        where TSelf : WordBuilder<TSelf>
    {
        protected Language language;
        protected Word word = new Word();
        public WordBuilder(Language language)
        {
            this.language = language;
        }
        public virtual TSelf AddWordText(string text)
        {
            word.WordText = text;
            return (TSelf)this;
        }
        public abstract TSelf AddTranslation(string text);
        public abstract TSelf AddInfo(string text);
        public virtual void FinishBuilding()
        {
            language.Words.Add(word);
            word = new Word();
        }
    }
    class WordBuilder : WordBuilder<WordBuilder>
    {
        public WordBuilder(Language language) : base(language) { }
        public override WordBuilder AddInfo(string text)
        {
            word.Info = text;
            return this;
        }
        public override WordBuilder AddTranslation(string text)
        {
            Translation t = new Translation(word, text);
            word.Translations.Add(t);
            return this;
        }
    }
}