using System;
namespace Exercises
{
    public class Exercise004
    {
        private static int gigaSecond = 1000000000;

        public static DateTime AddGigaSecond(DateTime dateTime)
            => dateTime.AddSeconds(gigaSecond);
    }
}
