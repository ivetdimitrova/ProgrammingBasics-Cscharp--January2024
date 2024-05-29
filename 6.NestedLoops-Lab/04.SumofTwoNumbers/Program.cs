namespace _04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = false;

            for (int i = start; i <=end; i++)
            {
                for(int j = start; j <=end; j++)
                {
                    counter++;
                    if(i + j==number) 
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {number})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
             if (!isFound)
            {
              Console.WriteLine($"{counter} combinations - neither equals {number}");
             }
        }

}
    }
