using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massiv
{
    public static class Rating
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество сотрудников: ");
            int rating = int.Parse(Console.ReadLine());

            int[] ratings = new int[rating];

            for (int i = 0; i < ratings.Length; i++)
            {
                Console.Write("Укажите рейтинг сотрудника: ");
                ratings[i] = int.Parse(Console.ReadLine());
            }

            int maxRating = ratings[0];

            for (int i = 0; i < ratings.Length; i++)
            {
                if (maxRating < ratings[i])
                {
                    maxRating = ratings[i];
                }
            }
            Console.WriteLine($"Наибольший рейтинг сотрудника: "+ maxRating);


        }
    }
}
