using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        // 👉 Remember to delete all unnecessary comments (like this one) when you're done! 

        public bool IsFromManchester(Person person)
        {
            if (person != null)
                return person.City == "Manchester";
            else
                return false;
        }

        public bool CanWatchFilm(/*Person person, int ageLimit*/)
        {
            // 👉 DON'T FORGET to uncomment the tests in Exercise002Tests.cs 
            // Uncomment the parameters above and delete this comment

            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }
    }
}
