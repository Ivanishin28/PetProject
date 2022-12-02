using PetProject.Dtos;
using PetProject.Filtering;
using PetProject.Models;
using PetProject.NewWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.EF
{
    static class PetProjectExtensions
    {
        public static IEnumerable<WordDto> OrderWordDto(this IEnumerable<WordDto> words,
            OrderWordDtoQuery query)
        {
            bool d = query.IsDescending;
            switch (query.OrderingType)
            {
                case OrderingType.WordText:
                    return d
                        ? words.OrderByDescending(w => w.WordText)
                        : words.OrderBy(w => w.WordText);
                case OrderingType.AddedDate:
                    return d
                        ? words.OrderByDescending(w => w.AddedDate)
                        : words.OrderBy(w => w.AddedDate);
                case OrderingType.TranslationsNumber:
                    return d
                        ? words.OrderByDescending(w => w.TranslationsNumber)
                        : words.OrderBy(w => w.TranslationsNumber);
                default: 
                    throw new ArgumentOutOfRangeException("There is no such an option");
            }
        }
    }
}