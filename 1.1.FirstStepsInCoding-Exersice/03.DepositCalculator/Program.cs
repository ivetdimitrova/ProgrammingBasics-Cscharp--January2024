namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double depositSum = double.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                double procent = double.Parse(Console.ReadLine()) / 100;

            double sum = depositSum + time *((depositSum* procent) / 12);
            Console.WriteLine(sum);


        }
    }
}