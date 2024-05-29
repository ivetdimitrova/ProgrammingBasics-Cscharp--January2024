namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double comm = 0;
            switch (town)
            {

                case "Sofia":
                    if (value < 0)
                    {
                        Console.WriteLine("error");
                    }
                    if (0 <= value && value <= 500)
                    {
                        comm = (value *5)/100;
                    }
                    else if (500<= value && value <= 1000)
                    {
                        comm = (value * 7)/100;
                    }
                    else if (1000<= value && value <= 10000)
                    {
                        comm = (value *8)/100;
                    }
                    else if (value > 10000)
                    {
                        comm = (value * 12)/100;
                    }


                    break;

                case "Varna":
                    if (value < 0)
                    {
                        Console.WriteLine("error");
                    }
                    if (0 <= value && value <= 500)
                    {
                        comm = (value *4.5)/100;
                    }
                    else if (500<= value && value <= 1000)
                    {
                        comm = (value * 7.5)/100;
                    }
                    else if (1000<= value && value <= 10000)
                    {
                        comm = (value *10)/100;
                    }
                    else if (value > 10000)
                    {
                        comm = (value *13)/100;
                    }

                    break;

                case "Plovdiv":
                    if (value < 0)
                    {
                        Console.WriteLine(" error");
                    }
                    else if (0 <= value && value <= 500)
                    {
                        comm = (value *5.5)/100;
                    }
                    else if (500<= value && value <= 1000)
                    {
                        comm = (value * 8)/100;
                    }
                    else if (1000<= value && value <= 10000)
                    {
                        comm = (value *12)/100;
                    }
                    else if (value > 10000)
                    {
                        comm = (value * 14.5)/100;
                    }
                    break;
            }
            switch (town)
            {
                case "Sofia":
                case "Plovdiv":
                case "Varna":
                 if (value >= 0)
                 { 
                   Console.WriteLine($"{comm:f2}");
                 }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}