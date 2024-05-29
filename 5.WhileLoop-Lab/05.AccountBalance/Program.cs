namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double allMoney = 0;

            while (input != "NoMoreMoney")
            {
                double money = double.Parse(input);

                if (money<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                
                    Console.WriteLine($"Increase: {money:f2}");
                    allMoney+= money;
               
                input= Console.ReadLine();
            }
            
            Console.WriteLine($"Total: {allMoney:f2}");
        }
    }
}