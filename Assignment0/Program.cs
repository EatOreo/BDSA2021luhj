using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Worl!");
        }

        public static bool isLeapYear(int year) {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
