namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());
         
            string presentationName = Console.ReadLine();
            int presentationsNumber = 0;
            double allSum = 0;

            while (presentationName != "Finish")
            {
                presentationsNumber++;
                double obhtasumanaoc = 0;
                for(int i = 0; i < juryNumber; i++)
                {
                    double ocenki = double.Parse(Console.ReadLine());
                    obhtasumanaoc+= ocenki;
                }
                double averageSumForOne = obhtasumanaoc/juryNumber;
                allSum+= averageSumForOne;
                Console.WriteLine($"{presentationName} - {averageSumForOne:f2}.");
                

                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allSum/presentationsNumber:f2}.");
        }
    }
}