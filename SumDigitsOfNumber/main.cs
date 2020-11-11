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
            string numb = (Console.ReadLine());
            long result = 0;
            char[] numbs = (numb.ToArray());
            foreach (var item in numbs)
            {
                Console.WriteLine(item);
                result += int.Parse(Convert.ToString(item));
            }
            Console.WriteLine(result);
        }

    }
}
