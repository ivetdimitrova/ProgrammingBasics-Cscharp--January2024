namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());




            double price = 0;
            double discount = 0;
            double overpriced = 0;
            //   Съществуват следните отстъпки:
            switch (type)
            {
                case "Roses":
                    price =count *5.00;
                    if (count > 80)
                    {
                        discount = price * 0.1;
                    }
                    break;
                case "Dahlias":
                    price =count* 3.80;
                    if (count > 90)
                    {
                        discount = price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = count * 2.80;
                    if (count > 80)
                    {
                        discount = price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = count * 3;
                    if (count < 120)
                    {
                        overpriced = price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = count * 2.50;
                    if (count < 80)
                    {
                        overpriced = price * 0.20;
                    }
                    break;
            }

            double totalCost = price - discount + overpriced;
            if (budget >= totalCost)
            {

                double lastmoney2 = budget - totalCost;




                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {lastmoney2:f2} leva left.");


            }
            else if(budget < totalCost )
            {

                double neededmoney2 = totalCost - budget;


                Console.WriteLine($"Not enough money, you need {neededmoney2:f2} leva more.");


            }


        }
    }
}