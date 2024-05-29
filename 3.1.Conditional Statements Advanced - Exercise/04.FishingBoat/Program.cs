namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
// Бюджет на групата – цяло число в интервала[1…8000]
           int budget = int.Parse(Console.ReadLine());
//· Сезон – текст: "Spring", "Summer", "Autumn", "Winter"
           string season = Console.ReadLine();
//· Брой рибари – цяло число в интервала[4…18]
            int fisherman = int.Parse(Console.ReadLine());

            double price = 0;
            switch (season)
            {
                case "Spring":
                    price += 3000;
                    break;
                case "Summer":
                    case  "Autumn":
                    price+=4200;
                    break;
                case "Winter":
                    price+=2600;
                    break;
            }

            if(fisherman <= 6)
            {
                price = price  * 0.9;
            }
            else if(fisherman >= 7 && fisherman <= 11)
            {
                price = price  * 0.85;

            }
            else if (fisherman >= 12)
            {
                price = price * 0.75;
            }
            
            if(fisherman % 2 == 0 && season != "Autumn")
            {
                    price = price  * 0.95;
            }

            if(budget >= price)
            {
                double lastmoney = budget - price;
                Console.WriteLine($"Yes! You have {lastmoney:f2} leva left.");
            }
            else
            {
                double needemoney = price - budget;
                Console.WriteLine($"Not enough money! You need {Math.Abs(needemoney):f2} leva.");
            }
        }
    }
}