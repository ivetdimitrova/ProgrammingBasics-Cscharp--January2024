namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            int num = 0; 

            for(int row = 1; row <= number; row++) 
            { 
                for(int positions = 1;positions<=row;positions++)
                {
                    num++;
                    if (num > number)
                        break;

                    Console.Write(num + " ");
                }
               Console.WriteLine();
            }
          
        }
    }
}