namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int border = int.Parse(Console.ReadLine());

            int number = 1;
            while(number<= border)
            {
                Console.WriteLine(number);
                number = number * 2 +1;
            }
        }
    }
}