using System;
using System.Linq;

namespace Advanced_Concepts.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shorten (this string str, int numberOfWords)
        {
            //Defensive Programming
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should be greater or equal to 0.");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
