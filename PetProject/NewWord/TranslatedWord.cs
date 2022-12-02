using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.NewWord
{
    internal class TranslatedWord
    {
        public string Word { get; set; }
        public IEnumerable<string> Translations { get; set; }
        public string Info { get; set; }
    }
}
