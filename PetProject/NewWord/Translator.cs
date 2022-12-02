using PetProject.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.NewWord
{
    abstract class Translator : BizLogicValidation, IIndexedTranslator
    {
        public abstract TranslatedWord Translate(string str);
        protected int currentLine;
        public TranslatedWord TranslateWithIndex(int i, string line)
        {
            currentLine = i;
            return Translate(line);
        }
    }
}
