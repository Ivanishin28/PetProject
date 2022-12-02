using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Models
{
    internal class Theme
    {
        public string ThemeName { get; set; }
        public List<Word> Words { get; set; }
        public string LanguageName { get; set; }
        public Language Language { get; set; }
        public string newStr { get; set; }
    }
}