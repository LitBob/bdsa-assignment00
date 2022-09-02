using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args != Array.Empty<string>() && args.Length > 0){
                foreach (var arg in args)
                {
                    int num = Int32.Parse(arg);
                    Console.WriteLine(YayOrNay(IsLeapYear(num)));   
                }
            } else
            {
                Console.WriteLine("Provide a year");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out var val))
                {
                    Console.WriteLine(YayOrNay(IsLeapYear(val)));
                } else Console.WriteLine("Error");
            }
        }

        static bool IsLeapYear(int year) 
        {
            if ((year % 4) == 0) {
                if ((year % 100) == 0) {
                    if ((year % 400) == 0) {
                        return true; 
                    }
                    return false;
                }
                return true;
            }
            return false;
        }

        static string YayOrNay(bool val)
        {
            if (val == true) return "yay";
            else return "nay";
        }
    }
}
