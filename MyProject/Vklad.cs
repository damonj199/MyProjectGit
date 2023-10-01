using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public static class Vklad
    {
        public static int ReadFromSummaVklada()
        {
            Console.WriteLine("Сумма вклада: ");
            string summa = Console.ReadLine();
            int sum = Convert.ToInt32(summa);
            return sum;
        }
        public static int ReadFromYears()
        {
            Console.WriteLine("Продолжительность вклада: ");
            string years = Console.ReadLine();
            int year = Convert.ToInt32(years);
            return year;
        }
        public static int ReadFromPercent()
        {
            Console.WriteLine("Годовая ставка %: ");
            string percent1 = Console.ReadLine();
            int percent = Convert.ToInt32(percent1);
            return percent;
        }
        public static void AddVklada()
        {
            int itog = 0;
            int year = ReadFromSummaVklada();

            for (int i = 0; i < ReadFromYears(); i++)
            {
                itog += ReadFromSummaVklada() / 100 * ReadFromPercent();
                year = itog;
                Console.WriteLine(itog);
            }
        }
    }
}
