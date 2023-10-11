//Задание 1

Console.Write("Количество поступивщих товаров: ");
int price = int.Parse(Console.ReadLine());

int[] prices = new int[price];

for (int i = 0; i < prices.Length; i++)
{
    Console.Write("Цена товара от поставщика: ");
    prices[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < prices.Length; i++)
{
    prices[i] += prices[i] * 18 / 100;

    Console.WriteLine($"Цена для продажи: " + prices[i]);
}
//Задание 2

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
Console.WriteLine($"Наибольший рейтинг сотрудника: " + maxRating);

//Задание 3

Console.Write("Количество работников: ");
int salePlan = int.Parse(Console.ReadLine());

Console.Write("Укажите план продаж: ");
int plan = int.Parse(Console.ReadLine());

int[] salePlans = new int[salePlan];
int staff = 0;

for (int i = 0; i < salePlans.Length; i++)
{
    Console.Write("Сумма продаж каждого сотрудника: ");
    salePlans[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < salePlans.Length; i++)
{
    if (salePlans[i] < plan)
    {
        staff++;
    }
}
Console.WriteLine($"Cотрудников не выполнивших план: " + staff);