namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            double recordinseconds = double.Parse(Console.ReadLine());
            //.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            double meters = double.Parse(Console.ReadLine());   
            //.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]
            double secondForOneMeters = double.Parse(Console.ReadLine());
            double FirstTime = meters * secondForOneMeters;
             double meteres2 =Math.Floor( meters / 15);
            double SEcondTime = meteres2 * 12.5;
            double realTime = FirstTime+ SEcondTime;
            if (realTime < recordinseconds)
            { //Ако Иван е подобрил Световния рекорд(времето му е по-малко от рекорда) отпечатваме:
                Console.WriteLine($" Yes, he succeeded! The new world record is {realTime:f2} seconds.");
            }
            else
            { //Ако НЕ е подобрил рекорда(времето му е по-голямо или равно на рекорда) отпечатваме:
                double lastseconds = realTime - recordinseconds;
                Console.WriteLine($"No, he failed! He was {lastseconds:f2} seconds slower.");
            }
        }
    }
}