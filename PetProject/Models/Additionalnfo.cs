using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Models
{
    class Additionalnfo
    {
        public int Id { get; set; }
        public string InfoText { get; set; }
        public Word Word { get; set; }
        public Additionalnfo() { }
        public Additionalnfo(Word word, string text)
        {
            InfoText = text;
            Word = word;
        }
    }
}
