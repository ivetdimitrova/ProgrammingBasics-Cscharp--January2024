namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // vkarvame kv.m
            int nylon = int.Parse(Console.ReadLine()); //10
            // vkarvame litri
            int paint = int.Parse(Console.ReadLine()); //11
            int thinner = int.Parse(Console.ReadLine()); //4
            //vreme za rabota 
            int hoursForWork = int.Parse(Console.ReadLine()); //8
            //izchislqvane cenata
            double paint2 = paint * 0.10;
            double priceForNylon = (nylon + 2) * 1.50; //(10 + 2) * 1.50 = 18 
            double priceForPaint = (paint + paint2)* 14.50; // (11 + 10/100) * 14.50 
            double priceForThinner = thinner * 5.00; // 4 . 5
            // cena za vs materiali
            double priceForMaterials= priceForNylon + priceForPaint + priceForThinner + 0.40;
            // za boqdjiq
            double priceForPainter = (priceForMaterials * 30/100) * hoursForWork;
            // kraina cena
            double finalPrice = priceForMaterials + priceForPainter;
            //izhod 
            Console.WriteLine(finalPrice);
        }
    }
}