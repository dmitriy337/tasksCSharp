using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int s = days%7;
            switch (s) {

                case 1: Console.WriteLine("6"); break; ;
                case 2: Console.WriteLine("7"); break; ;
                case 3: Console.WriteLine("1"); break; ;
                case 4: Console.WriteLine("2"); break; ;
                case 5: Console.WriteLine("3"); break; ;
                case 6: Console.WriteLine("4"); break; ;
                case 0: Console.WriteLine("5"); break; ;
            }

        }

    }
}
