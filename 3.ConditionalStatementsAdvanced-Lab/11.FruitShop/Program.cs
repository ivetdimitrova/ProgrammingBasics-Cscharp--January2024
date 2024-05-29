namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double priceForFood = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch(fruit)
                    {
                        case "banana":
                            priceForFood = 2.50;
                            break;
                        case "apple":
                            priceForFood = 1.20;
                            break;
                        case "orange":
                            priceForFood = 0.85;
                            break;
                        case "grapefruit":
                            priceForFood = 1.45;
                            break;
                        case "kiwi":
                            priceForFood = 2.70;
                            break;
                        case "pineapple":
                            priceForFood = 5.50;
                            break;
                        case "grapes":
                            priceForFood = 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch(fruit)
                    {
                        case "banana":
                            priceForFood = 2.70;
                            break;
                        case "apple":
                            priceForFood = 1.25;
                            break;
                        case "orange":
                            priceForFood = 0.90;
                            break;
                        case "grapefruit":
                            priceForFood = 1.60;
                            break;
                        case "kiwi":
                            priceForFood =3.00;
                            break;
                        case "pineapple":
                            priceForFood = 5.60;
                            break;
                        case "grapes":
                            priceForFood = 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            double priceForAll = count * priceForFood;

            if(priceForAll!=0)
            {
                Console.WriteLine($"{priceForAll:f2}");
            }
        }
    }
}