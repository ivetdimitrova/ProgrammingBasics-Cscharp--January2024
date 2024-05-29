namespace GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Въвеждаме две цели числа
            //първото число
            int num1 = int.Parse(Console.ReadLine());
            // бторото число
            int num2 = int.Parse(Console.ReadLine());   
            // сравняваме ги, за да разберем кое е по- голямото
            if(num1 > num2)
            { 
                Console.WriteLine(num1);
            }
            else 
            { 
                Console.WriteLine(num2); 
            }
        }
    }
}