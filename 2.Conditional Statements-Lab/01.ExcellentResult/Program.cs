namespace ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Четем оценката от конзолата
            double result = double.Parse(Console.ReadLine());
            // Цръвняване оценката ако е над 5.50 трябва да излезе Excellent! , ако не по малка от 5.50 да не се изкарва нищо
            if (result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}