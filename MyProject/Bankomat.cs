using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public static class Bankomat
    {
        public static int ReadFromCash() 
        {
            string cash1 = Console.ReadLine();
            int cash = Convert.ToInt32(cash1);
            return cash;
        }
        public static int AddCash()
        {
            int sum1 = AddCash();
            int thousend = 0;
            int five = 0;
            int one = 0;

            while (sum1 >= 1000)
            {
                sum1 -= 1000;
                thousend++;
            }
            while (sum1 >= 500)
            {
                sum1 -= 500;
                five++;
            }
            while (sum1 >= 100)
            {
                sum1 -= 100;
                one++;
            }
            Console.WriteLine("1000 " + thousend + " 500 " + five + " 100 " + one);
            return sum1;
        }
    }
}
