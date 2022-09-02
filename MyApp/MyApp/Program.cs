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
                    if (int.TryParse(arg, out var val)) 
                        if (val < 1582) Console.WriteLine("Year Out of Scope");
                        else Console.WriteLine(YayOrNay(IsLeapYear(val)));  
                    else Console.WriteLine("Input is Not a Number");
                }
            } else
            {
                Console.WriteLine("Provide a year");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out var val))
                {
                    if (val < 1582) Console.WriteLine("Year Out of Scope");
                    else Console.WriteLine(YayOrNay(IsLeapYear(val)));
                } else Console.WriteLine("Input is Not a Number");
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
