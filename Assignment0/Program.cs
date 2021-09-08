using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true) {
                System.Console.WriteLine("Enter a year and hit [Enter]");
                try {
                    string input = Console.ReadLine();
                    if (input == "end") break;
                    int year = Int32.Parse(input);
                    System.Console.WriteLine(isLeapYear(year) ? "yay" : "nay");
                } catch (Exception e) {
                    System.Console.WriteLine(e.Message);
                }
            }
        }

        public static bool isLeapYear(int year) {
            if (year < 1582) throw new Exception("The leap year function should only apply to years from 1582.");
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
