namespace VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int pages = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());   
            int days = int.Parse(Console.ReadLine());

            int timeForReading = pages / pagesForHour;
            int hourForDay = timeForReading/ days;

            Console.WriteLine(hourForDay);
        }
    }
}