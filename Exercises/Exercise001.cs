﻿using System;
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
            // Replace the exception statement below with your code!
            throw new NotImplementedException();

            // NB: Look in Exercise001Tests.cs
            //     There is a test with commented out assertions.
            //     For an extra challenge, uncomment those assertions and make that test pass too.
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
