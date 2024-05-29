namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Име на сериал – текст
            string nameOfSerial = Console.ReadLine();
            // Продължителност на епизод – цяло число- 
            int minutesOfSerial = int.Parse(Console.ReadLine());
            // Продължителност на почивката – цяло число - 
            int minutesOfBreak = int.Parse(Console.ReadLine());
            // Времето за обяд ще бъде 1/8 от времето за почивка
            double TimeForEat = minutesOfBreak/ 8.0;
            //времето за отдих ще бъде 1/4 от времето за почивка.
            double timeForRelax = minutesOfBreak / 4.0;

            double neededTime = minutesOfSerial + TimeForEat + timeForRelax;

            double lastTime = Math.Abs(neededTime- minutesOfBreak);

            if (neededTime <= minutesOfBreak)
            {
                Console.WriteLine($"You have enough time to watch {nameOfSerial} and left with {Math.Ceiling(lastTime)} minutes free time.");
            }
            else
            {
               
                Console.WriteLine($"You don't have enough time to watch {nameOfSerial}, you need {Math.Ceiling(lastTime)} more minutes.");
            }
        }
    }
}