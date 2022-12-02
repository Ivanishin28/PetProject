using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Dtos
{
    internal class WordDto
    {
        public string WordText { get; set; }
        public string Info { get; set; }
        public string TranslationsString { get; set; }
        public DateTime AddedDate { get; set; }
        public int TranslationsNumber { get; set; }
    }
}
