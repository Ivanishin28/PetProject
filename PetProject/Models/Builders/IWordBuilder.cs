using PetProject.NewWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Models.Builders
{
    internal interface IWordBuilder
    {
        Word Build(TranslatedWord translatedWord);
    }
}
