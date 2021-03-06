using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a year and press the 'Enter' button. Then we will see if you have found a leap year.");

            
            int year = getInput();

            if(IsLeapYear(year))
            {
                Console.WriteLine("yay");
            }
            else
            {
                if(year >= 1582) Console.WriteLine("nay");
            }

        }

        private static int getInput()
        {
            string input = Console.ReadLine();
            try
            {
                int year = Int16.Parse(input);   
                return year;  
            }
            catch (System.Exception)
            {
                Console.WriteLine("That is a not a number!");
                return getInput();
                throw;
            }
        }
        public static bool IsLeapYear(int year)
        {
            if(year <= 1582) { Console.WriteLine("Too long ago, year must be after 1582."); return false;}
            
            if (year % 4 == 0)
            {
                if(year % 100 == 0 && year % 400 != 0)
                {
                    return false;
                }
                return true;   
            }
            else
            {
                return false;
            }
        }


    }
}
