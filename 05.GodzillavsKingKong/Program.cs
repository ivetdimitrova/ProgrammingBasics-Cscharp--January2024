namespace GodzillavsKingKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            double moneyForFilm = double.Parse(Console.ReadLine());
            //Брой на статистите – цяло число в интервала[1 … 500]
            int countStilists = int.Parse(Console.ReadLine());
            //Цена за облекло на един статист – реално число в интервала
            double moneyForCloths = double.Parse(Console.ReadLine());
            // 10% ot budjeta e dekora
            double moneyForDecoretons = moneyForFilm * 0.1;
            //pri poveche ot 150 stilista ima otstypka 10%
            double moneyForStilistsClothing = countStilists * moneyForCloths;
            //double moneyWithDiscountClothing = 0;
            if(countStilists > 150) 
            {
                moneyForStilistsClothing = moneyForStilistsClothing - (moneyForStilistsClothing * 0.1);
            }
            double priceForAll = moneyForDecoretons + moneyForStilistsClothing;
            //Ако парите за декора и дрехите са повече от бюджета:
            if (priceForAll > moneyForFilm)
            {
                Console.WriteLine("Not enough money!");
                double needemoney = priceForAll - moneyForFilm;
                Console.WriteLine($"Wingard needs {needemoney:f2} leva more.");
            }
            else if (priceForAll <= moneyForFilm)
            {
                // Ако парите за декора и дрехите са по малко или равни на бюджета:

                Console.WriteLine("Action!");
                double lastmoney = moneyForFilm- priceForAll;
                Console.WriteLine($"Wingard starts filming with {lastmoney:f2} leva left.");
            }
        }
    }
}