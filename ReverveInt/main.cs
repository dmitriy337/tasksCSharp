using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Unicode;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] CharStr = str.ToCharArray();
            Array.Reverse(CharStr);
            string MyNumb = "";
            foreach (var i in CharStr)
            {
                MyNumb += i;
            }
            Console.WriteLine(Convert.ToInt64(MyNumb));

        }


    }
}