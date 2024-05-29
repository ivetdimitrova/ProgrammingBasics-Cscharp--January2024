namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //    офисът на фирма е отворен, като работното време на офисът е от 10-18 часа,
            //    от понеделник до събота включително
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour >= 10 && hour<= 18)
            {
                switch (day)
                {

                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    default:
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}