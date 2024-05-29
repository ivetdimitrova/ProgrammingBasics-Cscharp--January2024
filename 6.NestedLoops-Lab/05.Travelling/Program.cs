namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string destination = Console.ReadLine();
            
            while(destination != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
              
                double  collectedMoney = 0;

                while (collectedMoney < neededMoney)
                {
                    double money = double.Parse(Console.ReadLine());
                    collectedMoney += money;
                }

                Console.WriteLine($"Going to {destination}!");

                destination= Console.ReadLine();
            }

        }
    }
}