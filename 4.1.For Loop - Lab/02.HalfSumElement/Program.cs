namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = 0;
            for(int i =0; i < n; i++) 
            { 
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if(number > maxNumber) 
                { 
                  maxNumber= number;
                }
            }
            sum -= maxNumber;

            if(sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int difference = maxNumber- sum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(difference)}");
            }

        }
    }
}