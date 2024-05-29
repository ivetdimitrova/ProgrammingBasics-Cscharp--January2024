namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openedTabs = int.Parse(Console.ReadLine());
           double salary = double.Parse(Console.ReadLine());

            //double fine = 0;

            for(int i = 0 ; i < openedTabs; i++) 
            {
                string nameTab = Console.ReadLine();
                switch(nameTab)
                {
                    case "Facebook":
                        salary -=150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
               
                if(salary<=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if(salary >=1)
            {
                Console.WriteLine($"{salary}");
            }
            

        }
    }
}