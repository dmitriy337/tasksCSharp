using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int FirtDay = Convert.ToInt32((data.Split(" "))[1]);
            int Days = Convert.ToInt32((data.Split(" "))[0]);
            int s = Days * 37 + FirtDay;
            Console.WriteLine($"{s / 23} {s % 23}");

        }
    }
}
