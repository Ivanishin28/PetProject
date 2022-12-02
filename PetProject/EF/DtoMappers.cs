using PetProject.Dtos;
using PetProject.Models;
using PetProject.NewWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.EF
{
    internal static class DtoMappers
    {
        private static string CreateTranslationsString(char separator, Word word)
        {
            return string.Join(NewTranslator.TranslationsSeparator,
                    word.Translations
                        .Select(t => t.TranslationText)
                        .ToArray());
        }
        public static IEnumerable<WordDto> MapWordToDto(this IEnumerable<Word> words)
        {
            return words.Select(w => new WordDto
            {
                WordText = w.WordText,
                Info = w.Info,
                TranslationsString = 
                    CreateTranslationsString(NewTranslator.TranslationsSeparator, w),
                AddedDate = w.AddedDate,
                TranslationsNumber = w.Translations.Count
            });
        }
        public static IEnumerable<TestingDto>
            MapWordToTesting(this IEnumerable<Word> words)
        {
            return words.Select(w => new TestingDto()
            {
                WordText = w.WordText,
                TranslationsString =
                    CreateTranslationsString(NewTranslator.TranslationsSeparator, w)
            });
        }
    }
}
