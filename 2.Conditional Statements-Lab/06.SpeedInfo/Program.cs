namespace SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //  чете скорост(реално число)
           double speed = double.Parse(Console.ReadLine());

            // При скорост до 10(включително) отпечатайте "slow"
            if (speed <= 10)
                Console.WriteLine("slow");
            //При скорост над 10 и до 50(включително) отпечатайте "average"
            else if (speed > 10 && speed <= 50)
                Console.WriteLine("average");
            //При скорост над 50 и до 150(включително) average "fast"
            else if (speed > 50 && speed<= 150)
                Console.WriteLine("fast");
            //При скорост над 150 и до 1000(включително) отпечатайте "ultra fast"
            else if (speed > 50 && speed<= 1000)
                Console.WriteLine("ultra fast");
            //При по-висока скорост отпечатайте "extremely fast"
            else if(speed >1000)
            Console.WriteLine("extremely fast");
        }
    }
}