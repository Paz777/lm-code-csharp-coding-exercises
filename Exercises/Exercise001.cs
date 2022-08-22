using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            //refactor as ternary
            if (word != null && word != string.Empty)
            {
                return char.ToUpper(word[0]) + word.Substring(1);
            }
            else
                return word;
        }

        public string GenerateInitials(string firstName, string lastName)
            =>  firstName.Substring(0, 1) + "." + lastName.Substring(0, 1);

        public double AddVat(double originalPrice, double vatRate)
        {
            if (originalPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative. Please enter a valid price.");
            }
            else if (vatRate < 0)
            {
                throw new ArgumentException("VAT cannot be negative. Please enter a valid VAT.");
            }
            else
                return Math.Round(originalPrice + (originalPrice * vatRate / 100), 2);
        }

        public string Reverse(string sentence)
        {
            if (sentence != null)
            {
                char[] sentenceCharArray = sentence.ToCharArray();
                Array.Reverse(sentenceCharArray);
                return new string(sentenceCharArray);
            }
            else
                return sentence;

        }

        public int CountLinuxUsers(List<User> users)
        {
            // refactor using linq
            int noOfLinuxUsers = 0;
            if (users != null)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Type == "Linux")
                    {
                        noOfLinuxUsers += 1;
                    }
                }
            }
            return noOfLinuxUsers;
        }
    }
}
