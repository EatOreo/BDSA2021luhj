using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a year and hit [Enter]");
            int year = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine(isLeapYear(year) ? "yay" : "nay");
            
        }

        public static bool isLeapYear(int year) {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
