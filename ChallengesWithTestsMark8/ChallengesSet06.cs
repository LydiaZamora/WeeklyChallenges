using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if(ignoreCase == true)
            {
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }

            if(ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;

            if(num >= 0)
            {
                if(num % 2 != 0 && num % 3 !=0)
                {
                    isPrime = true;
                }
            }

            if(num == 2 || num == 3)
            {
                isPrime = true;
            }

            if(num == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
