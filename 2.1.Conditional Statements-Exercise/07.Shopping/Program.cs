namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Бюджетът на Петър - реално число-
            double budget = double.Parse(Console.ReadLine());
            //Броят видеокарти - цяло число- cena 250 лв./бр.
            int videocards = int.Parse(Console.ReadLine());
            double priceForVideoCards = videocards * 250;
            //Броят процесори - цяло число - cena 35% от цената на закупените видеокарти/бр.
           int  processor = int.Parse(Console.ReadLine());
            double priceForProcessor = processor *(priceForVideoCards * 0.35);
            //Броят рам памет -цяло число- cena 10% от цената на закупените видеокарти/бр.
               int ram = int.Parse(Console.ReadLine());
            double priceForRam = ram * (priceForVideoCards * 0.1);

            double priceForAll = priceForVideoCards + priceForProcessor + priceForRam;
            if(videocards>processor)
            {
                priceForAll = priceForAll - (priceForAll * 0.15);
            }
            // Ако бюджета е достатъчен:
            if (priceForAll <= budget)
            {
                double lastmoney = budget - priceForAll;
                Console.WriteLine($"You have {lastmoney:f2} leva left!");
            }
            else // Ако сумата надхвърля бюджета:
            {
                double neededmoney = priceForAll - budget;
                Console.WriteLine($"Not enough money! You need {neededmoney:f2} leva more!");
            }
        }
    }
}