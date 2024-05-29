namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            int freePlace = width* length * heigth;
            int filledPlace = 0;

            string input = Console.ReadLine(); 
        
            while(input != "Done")
            {
              int countOfCartons = int.Parse(input);
                filledPlace += countOfCartons;
                if(filledPlace > freePlace)
                {
                    Console.WriteLine($"No more free space! You need {filledPlace - freePlace} Cubic meters more.");
                    break;
                }

                input = Console.ReadLine();
            }
            if(freePlace > filledPlace)
            {
                Console.WriteLine($"{freePlace - filledPlace} Cubic meters left.");
            }
        }
    }
}