namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceForOneYear = int.Parse(Console.ReadLine());

            
            double priceForSneakers = priceForOneYear - priceForOneYear * 0.4;
            double priceForEkip = priceForSneakers - priceForSneakers * 0.2;
            double priceForBall = priceForEkip / 4 ;
            double priceForAcces =  priceForBall / 5;

            double priceAll = priceForOneYear + priceForSneakers + priceForEkip + priceForBall + priceForAcces;
            Console.WriteLine(priceAll);
        }
    }
}