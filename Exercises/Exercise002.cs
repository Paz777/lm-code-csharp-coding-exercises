﻿using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
            => person != null ? person.City == "Manchester" : false;

        public bool CanWatchFilm(Person person, int ageLimit)
            => person.Age >= ageLimit ? true : false;
    }
}
