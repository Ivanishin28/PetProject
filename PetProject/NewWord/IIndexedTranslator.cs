using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.NewWord
{
    internal interface IIndexedTranslator
    {
        TranslatedWord TranslateWithIndex(int i, string line);
    }
}
