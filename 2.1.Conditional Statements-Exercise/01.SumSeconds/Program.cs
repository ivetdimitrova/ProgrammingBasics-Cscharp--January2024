namespace SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vyvejdame secundite na trimata systezateli
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());

            int sumSeconds =firstPlayer + secondPlayer + thirdPlayer;

            int minutes = sumSeconds/ 60;
            int secunds = sumSeconds% 60;

            if(secunds< 10)
            Console.WriteLine($"{minutes}:0{secunds}");
            else
                Console.WriteLine($"{minutes}:{secunds}");


        }
    }
}