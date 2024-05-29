namespace Number100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vyvejdah chislo ot konzolata
            int number = int.Parse(Console.ReadLine());
            // dali e pod 100
            if (number < 100)
            Console.WriteLine("Less than 100");
            //dali e nad 100 i pod 200
            else if (number>= 100 && number <= 200)
                Console.WriteLine("Between 100 and 200");
            // dali e nad 200
            else if(number > 200)
                Console.WriteLine("Greater than 200");

        }
    }
}