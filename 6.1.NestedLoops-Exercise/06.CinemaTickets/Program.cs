using System.Linq.Expressions;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string filmName = Console.ReadLine();

            int countStudentTickets = 0;
            int countStandardTickets = 0;
            int countKidTickets = 0;

            while (filmName != "Finish")
            {
                int freeTickets = int.Parse(Console.ReadLine());

                string type = string.Empty;
                int buyTickets = 0;
                while (buyTickets < freeTickets)
                {
                    type = Console.ReadLine();

                    if (type == "End")
                        break;

                    buyTickets++;

                    if (type == "student")
                        countStudentTickets++;
                    else if (type == "standard")
                       countStandardTickets++;
                    else
                        countKidTickets++;
                }

                Console.WriteLine($"{filmName} - {(double)buyTickets / freeTickets *100:f2}% full.");

                filmName = Console.ReadLine() ;
            }

            int totalTickets = countStudentTickets + countKidTickets + countStandardTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)countStudentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)countStandardTickets/ totalTickets * 100 :f2}% standard tickets.");
            Console.WriteLine($"{(double)countKidTickets / totalTickets * 100 :f2}% kids tickets.");
           
        }
    }
}