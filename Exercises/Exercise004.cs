using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
            => dateTime.AddSeconds(1000000000);
    }
}
