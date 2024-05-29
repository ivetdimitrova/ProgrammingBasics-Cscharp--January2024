namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            //double priceForAll = 0;
            string place = " ";
            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        price = budget * 0.3;
                        place = "Camp";
                        break;
                    case "winter":
                        price = budget * 0.7;
                        place = "Hotel";
                        break;
                }
                //priceForAll = budget - priceWithDiscount;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine($"{place} - {price:f2}");
            }
            else if (budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        price = budget  * 0.4;
                        place = "Camp";
                        break;
                    case "winter":
                        price = budget  * 0.8;
                        place = "Hotel";
                        break;
                }
                //priceForAll = budget - priceWithDiscount;

                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine($"{place} - {price:f2}");
            }
           else  if (budget > 1000)
            {

                price = budget * 0.9;
                //priceForAll = budget - priceWithDiscount;

                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {price:f2}");
            }
        }
    }
}