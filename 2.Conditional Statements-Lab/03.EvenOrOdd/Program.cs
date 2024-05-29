namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Въвеждаме цяло число
            int number = int.Parse(Console.ReadLine());
            //проверяваме дали числото е четно ,ако е четно изписваме  "even , ако е нечетно трябва да се изпише "odd"
            if(number % 2 == 0 ) 
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}