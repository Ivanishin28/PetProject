using PetProject.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.NewWord
{
    internal class NewTranslator : Translator
    {
        public static char WordsSeparator => wordsSeparator;
        private static char wordsSeparator  = '-';
        public static char TranslationsSeparator => translationsSeparator;
        private static char translationsSeparator  = ' ';
        public static char[] InfoSeparators => infoSeparators;
        private static char[] infoSeparators  = { '(', ')' };
        public NewTranslator() { }
        public NewTranslator(char wordsSeparator, char translationsSeparator, char[] infoSeparators)
        {
            NewTranslator.wordsSeparator = wordsSeparator;
            NewTranslator.translationsSeparator = translationsSeparator;
            NewTranslator.infoSeparators = infoSeparators;
        }
        public override TranslatedWord Translate(string line)
        {
            if (String.IsNullOrEmpty(line))
            {
                ValidationErrorUnit error
                       = new ValidationErrorUnit(currentLine, BizLogicErrors.EmptyLine);
                Errors.Add(error);
                return null;
            }
            TranslatedWord translatedWord = new TranslatedWord();
            string[] word_translation = line.Split(wordsSeparator);
            if(word_translation.Length != 2)
            {
                ValidationErrorUnit error 
                    = new ValidationErrorUnit(currentLine, BizLogicErrors.Error);
                Errors.Add(error);
                return null;
            }
            string word = word_translation[0];
            string rightSide = word_translation[1];
            string[] translations;
            string info = null;
            int leftInfoSepId = rightSide.IndexOf(infoSeparators[0]);
            if(leftInfoSepId >= 0)
            {
                int rightInfoSepId = rightSide.IndexOf(infoSeparators[1]);
                info = rightSide
                    .Substring(leftInfoSepId + 1, rightInfoSepId - leftInfoSepId - 1);
                translations =
                    rightSide
                    .Remove(leftInfoSepId, rightInfoSepId - leftInfoSepId + 1)
                    .Split(new[] {translationsSeparator}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(str => str.Trim(' '))
                    .ToArray();
            }
            else
            {
                translations = rightSide
                    .Split(TranslationsSeparator, StringSplitOptions.RemoveEmptyEntries);
            }
            translatedWord.Word = word.Trim(' ');
            translatedWord.Translations = translations;
            translatedWord.Info = info?.Trim(' ');
            return translatedWord;
        }
    }
}
