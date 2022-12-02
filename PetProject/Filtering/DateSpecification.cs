using PetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Filtering
{
    internal class DateSpecification : ISpecification<Word>
    {
        public enum DateSpecType
        {
            Before,
            Now,
            After,
        }
        private DateSpecType specType;
        private DateTime date;
        public DateSpecification(DateTime date, DateSpecType dateSpecType)
        {
            this.date = date;
            specType = dateSpecType;
        }
        public bool IsSatisfied(Word word)
        {
            int res = DateTime.Compare(word.AddedDate.Date, date.Date);
            switch (specType)
            {
                case DateSpecType.Before:
                    if(res <= 0)
                    {
                        return true;
                    }
                    break;
                case DateSpecType.Now:
                    if (res == 0)
                    {
                        return true;
                    }
                    break;
                case DateSpecType.After:
                    if (res >= 0)
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
