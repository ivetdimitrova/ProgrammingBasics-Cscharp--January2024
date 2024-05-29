namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int dyljina = int.Parse(Console.ReadLine());
           int hirochina = int.Parse(Console.ReadLine());
           int visochina = int.Parse(Console.ReadLine());
           double prochent = double.Parse(Console.ReadLine()) ;

            double obem = dyljina * hirochina * visochina;
            double L = obem / 1000;
            double procent = prochent/ 100;
            double nujniLitri = L *(1 - procent);
            Console.WriteLine(nujniLitri);


        }
    }
}