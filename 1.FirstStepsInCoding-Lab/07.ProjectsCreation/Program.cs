namespace ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string architectsName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = projects * 3; 
            Console.WriteLine($"The architect {architectsName} will need {hours} hours to complete {projects} project/s.");
        }
    }
}