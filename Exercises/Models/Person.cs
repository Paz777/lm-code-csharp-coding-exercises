using System;
namespace Exercises.Models
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        public Person(string firstName, string lastName, string city, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Age = age;
        }
    }
}

