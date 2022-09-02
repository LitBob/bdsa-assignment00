using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                int num = Int32.Parse(arg);
                Console.WriteLine(IsLeapYear(num));   
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
    }
}
