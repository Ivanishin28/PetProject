using PetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Filtering
{
    internal class LanguageSpecification : ISpecification<Word>
    {
        private string language;
        public LanguageSpecification(Language language)
        {
            this.language = language.Name;
        }
        public LanguageSpecification(string language)
        {
            this.language = language;
        }
        public bool IsSatisfied(Word t)
        {
            return t.Language.Name == language;
        }
    }
}
