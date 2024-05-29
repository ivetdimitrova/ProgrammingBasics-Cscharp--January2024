namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            int places = rows * colums;
            double income = 0.0;
            switch (type)
            {
                case "Premiere":
                    income = places * 12.00;
                    break;
                case "Normal":
                    income = places * 7.50;
                    break;
                case " Discount":
                    income = places * 5.00;
                    break;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}