namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //  спрямо времето
                // от денонощието и градусите да препоръча на Виктор какви дрехи да си облече. Вашия приятел има различни
                //   планове за всеки етап от деня, които изискват и различен външен вид, тях може да видите от таблицата.
  
                int degress = int.Parse(Console.ReadLine());
                string time = Console.ReadLine();
            switch(time) 
            {
                case "Morning":
                    if(10<= degress && degress<= 18) 
                    {
                        Console.WriteLine($"It's {degress} degrees, get your Sweatshirt and Sneakers.");
                    }
                    else if (degress <= 24) 
                    {
                        Console.WriteLine($"It's {degress} degrees, get your Shirt and Moccasins.");

                    }
                    else if(degress<= 25)
                    {
                        Console.WriteLine($"It's {degress} degrees, get your T-Shirt and Sandals.");

                    }
                    break;
                case "Afternoon":
                    if (10<= degress && degress<= 18)
                    {
                        Console.WriteLine($"It's {degress} degrees, get your Shirt and Moccasins.");
                    }
                    else if (degress <= 24)
                    {
                        Console.WriteLine($"It's {degress} degrees, get your T-Shirt and Sandals.");

                    }
                    else if (degress<= 25)
                    {
                        Console.WriteLine($"It's {degress} degrees, get your Swim Suit and Swim Suit.");

                    }
                    break;
                case "Evening":
                    Console.WriteLine($"It's {degress} degrees, get your Shirt and Moccasins.");
                    break;


            }
        }
    }
}