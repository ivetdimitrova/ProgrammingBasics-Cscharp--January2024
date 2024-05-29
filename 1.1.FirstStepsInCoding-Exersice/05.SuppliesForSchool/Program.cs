namespace SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pen = int.Parse(Console.ReadLine());
            int markers=int.Parse(Console.ReadLine());  
            int litersForCleaning = int.Parse(Console.ReadLine());  
            int reduction = int.Parse(Console.ReadLine());

            double priceForPen = pen * 5.80;
            double priceForMarkers = markers * 7.20;
            double priceForCleaning = litersForCleaning * 1.20;

            double priceAll = priceForPen + priceForMarkers + priceForCleaning;
            double priceWithReduction = priceAll - (priceAll * reduction / 100);
            Console.WriteLine(priceWithReduction);
        }
    }
}