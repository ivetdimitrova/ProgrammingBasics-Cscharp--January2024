namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonusPinhts = 0.0;
            if (number <= 100)
                bonusPinhts = 5;
            else if (number > 1000)
                bonusPinhts = number * 0.1;
            else 
                bonusPinhts = number *0.2;

            if (number% 2 == 0)
                bonusPinhts += 1;
            else if (number % 10 == 5)
                bonusPinhts += 2;
            Console.WriteLine(bonusPinhts);
            Console.WriteLine(number + bonusPinhts);


        }
    }
}