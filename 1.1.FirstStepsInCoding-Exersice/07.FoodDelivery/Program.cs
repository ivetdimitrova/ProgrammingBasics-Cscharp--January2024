namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chiken =int.Parse(Console.ReadLine());
                int fish = int.Parse(Console.ReadLine());
                int  vegan = int.Parse(Console.ReadLine());

            double priceForChiken = chiken * 10.35;
            double priceForFish = fish * 12.40;
            double priceForVegan = vegan * 8.15;

            double priceWihtoutDesert = priceForChiken + priceForFish + priceForVegan;
            double priceForDesert = priceWihtoutDesert * 20/100;
            double price = priceWihtoutDesert + priceForDesert + 2.50;

            Console.WriteLine(price);
        }
    }
}