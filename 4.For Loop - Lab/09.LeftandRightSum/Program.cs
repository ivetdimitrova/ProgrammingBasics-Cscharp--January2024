namespace _09.LeftandRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0;i< n;i++) 
            { 
              int numbers1 = int.Parse(Console.ReadLine());
                sum1+= numbers1;
            }
            for(int i = 0; i < n; i++)
            {
                int numbers2 = int.Parse(Console.ReadLine());
                sum2+= numbers2;
            }

            if(sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = { sum1}");
            }
            else
            {
                int difference = sum1 - sum2;
                Console.WriteLine($"No, diff = { Math.Abs(difference)}");
            }
        }
    }
}