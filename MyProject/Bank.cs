using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public static class Bank
    {
        public static string ReadFromName()
        {
            Console.WriteLine("Ввeдите имя: ");
            string name = Console.ReadLine();
            return name;
        }
        public static int ReadFronAge()
        {
            Console.WriteLine("Ваш возраст: ");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            return age1;
        }
        public static int ReadFronCountProductBank()
        {
            Console.WriteLine("Сколько продуктов банка используете?");
            string countProd = Console.ReadLine();
            int coun = Convert.ToInt32(countProd);
            return coun;
        }
        public static int ReadFromAmountOfMoney()
        {
            Console.WriteLine("Какую сумму храните в банке?");
            string money1 = Console.ReadLine();
            int money = Convert.ToInt32(money1);
            return money;
        }
        public static int AddSale()
        {
            if (ReadFronAge() >= 60)
            {
                Console.WriteLine("Для Вас есть акционые предложения!");
            }
            else if (ReadFromAmountOfMoney() > 1000000)
            {
                Console.WriteLine("Для Вас есть акционые предложения!");
            }
            else if (ReadFromAmountOfMoney() > 400000 && ReadFronCountProductBank() >= 3)
            {
                Console.WriteLine("Для Вас есть акционые предложения!");
            }
            else
            {
                Console.WriteLine("Для Вас нет ни каких акций!");
            }
            return 0;
        }
    }

}
