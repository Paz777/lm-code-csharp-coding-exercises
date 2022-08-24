using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            const string ALPHABET = "abcdefghijklmnopqrstuvwxyz";
            return ALPHABET.All(input.ToLower().Contains);
        }
    }
}
