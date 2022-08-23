using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.All(input.ToLower().Contains);
        }
    }
}
