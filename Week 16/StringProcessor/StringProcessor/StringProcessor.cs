using System;

namespace StringProcessor
{
    public class Processor
    {
        /// <summary>
        /// Returns number of char found in word.  Case-insensitive.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int CountChar(string word, char c) {
            int count = 0;
            string lowercaseword = word.ToLower();
            foreach (char character in lowercaseword)
            {
                if (character == c)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Returns word in reverse.  Case sensitive.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public string Reverse(string word) {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Replaces all spaces in a word with char.  Case sensitive.  Replaces pre and trailing spaces
        /// </summary>
        /// <param name="word"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public string ReplaceSpace(string word, char c) {
            string character = Convert.ToString(c);
            string new_word = word.Replace(" ", character);
            return new_word;
        }
    }
}
