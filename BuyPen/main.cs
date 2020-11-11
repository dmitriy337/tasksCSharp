using System;

namespace Ex1034
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] price = Console.ReadLine().Trim().Split();
            string[] wowPrice = Console.ReadLine().Trim().Split();
            // Расчёт в копейках
            int pricePanInCent = int.Parse(price[0]) * 100 + int.Parse(price[1]);
            int haveMoney = int.Parse(wowPrice[0]) * 100 + int.Parse(wowPrice[1]);
            // 1-й вывод
            Console.WriteLine(haveMoney/pricePanInCent);
            // 2-й вывод
            Console.WriteLine(haveMoney%pricePanInCent/100 + " " + haveMoney%pricePanInCent%100);
        }
    }
}
