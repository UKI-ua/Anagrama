using System;
using System.Collections.Generic;
using System.Text;

namespace Anagrama
{
    public class Anagram
    {
        public string GetOutput(string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new Exception("Incorrect line");

            var wordsArr = s.Split();

            for (int i = 0; i < wordsArr.Length; i++)
            {
                wordsArr[i] = ReverseSymbol(wordsArr[i]);
            }

            return string.Join(' ', wordsArr);
        }

        private string ReverseSymbol(string word)
        {
            var revArray = new char[word.Length];
            var revDiraction = revArray.Length - 1;

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetter(word[revDiraction - i]))
                {
                    revArray[revDiraction - i] = word[revDiraction - i];
                }

                if (char.IsLetter(word[i]))
                {
                    for (int j = revDiraction; j >= 0; j--)
                    {
                        if (revArray[j] == '\0' && char.IsLetter(word[j]))
                        {
                            revArray[j] = word[i];
                            break;
                        }
                    }
                }
            }

            return new string(revArray);

        }

    }
}
