using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Models
{
    class Language
    {
        public string Name { get; set; }
        public List<Word> Words { get; } = new List<Word>(); 
        public List<Theme> Themes { get; set; }
        //del this, I think
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var w in Words)
            {
                sb.AppendLine(w.ToString());
            }
            return sb.ToString();
        }
    }
}