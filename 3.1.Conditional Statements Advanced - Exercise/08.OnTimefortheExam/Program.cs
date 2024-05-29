using System.Diagnostics.Metrics;
using System.IO;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace _08.OnTimefortheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());



            // превръщам часа на започване на изпита в минути и прибавям минутите на започване на изпита
            int examTimeInMinutes = examHour * 60 + examMinutes;
            // превръщам часа на явяване за изпита в минути и прибавям минутите на явяване за изпита
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinutes;
            // намирам разликата във времената
            int timeDifference = arrivalTimeInMinutes - examTimeInMinutes;

            // започвам проверки за разликата във времената 
            // “Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            if (timeDifference < -30)
            {
                Console.WriteLine("Early");
            }
            // “On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            else if (timeDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            // “Late”, ако студентът пристига по-късно от часа на изпита.
            else
            {
                Console.WriteLine("Late");
            }

            if (timeDifference != 0)
            {
                int hours = Math.Abs(timeDifference / 60);
                int minutes = Math.Abs(timeDifference % 60);

                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours {(timeDifference < 0 ? "before" : "after")} the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes {(timeDifference < 0 ? "before" : "after")} the start");
                }

            }
           
        }
    }
}