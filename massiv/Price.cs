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
