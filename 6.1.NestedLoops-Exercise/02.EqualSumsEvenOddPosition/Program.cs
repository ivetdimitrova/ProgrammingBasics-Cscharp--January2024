namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int startPosition = int.Parse(Console.ReadLine());
           int endPosition = int.Parse(Console.ReadLine());


            for(int i = startPosition; i < endPosition; i++)
            {
                string num = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for(int j = 0; j < num.Length; j++)
                {
                    int digit = (int)num[j];

                    if(j%2==0)
                        evenSum+= digit;
                    if(j%2!=0)
                        oddSum+= digit;
                }
                if(evenSum == oddSum)
                    Console.Write(num + " ");
            }
        }
    }
}