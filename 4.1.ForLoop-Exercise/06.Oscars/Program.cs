using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //string actorsName = Console.ReadLine();
           // double points = double.Parse(Console.ReadLine());
           // int raters = int.Parse(Console.ReadLine());

           // for(int i = 0; i < raters; i++)
           // {
           //     string raterName = Console.ReadLine();
           //     double point = double.Parse(Console.ReadLine());

           //     int countOfLeters = raterName.Length;

           //     points =  points + ((point * countOfLeters)/2);

           // }
           // if(points > 1250.5)
           // {
           //     Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {points}!");
           // }
           // else
           // {

           //     Console.WriteLine($"Sorry, {actorsName} you need {Math.Abs(points - 1250.5)} more!");
           // }

            string actorName = Console.ReadLine();
            double pointsForAcademy = double.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                string name = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                pointsForAcademy += (name.Length) * points / 2;

                if (pointsForAcademy>= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsForAcademy:f1}!");
                    break;
                }
            }

            if (pointsForAcademy < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {Math.Abs(pointsForAcademy - 1250.5):f1} more!");
            }
        }
    }
}