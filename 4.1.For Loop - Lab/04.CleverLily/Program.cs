namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceForLaundry = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int allMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    allMoney += i * 5 -1;
                }
                else
                {
                    allMoney += priceToy;
                }
            }
           
            if (allMoney >= priceForLaundry)
            {

                Console.WriteLine($"Yes! {allMoney - priceForLaundry:f2}");
              
            }
            else
            {

                Console.WriteLine($"No! {priceForLaundry - allMoney:f2}");
               
            }
            //int age = int.parse(console.readline());
            //double washingmachine = double.parse(console.readline());
            //int toyprice = int.parse(console.readline());

            //2. създаваме променлива, в която да пазим парите, които лили спестява
            //int money = 0;

            //3. създаваме цикъл, който да премине през всеки един рд на лили
            //for (int birthday = 1; birthday <= age; birthday++)
           // {
                //=> за всеки рд ще проверяваме дали е четен => if (рождения ден е четен)
               //if (birthday % 2 == 0)
                    //==> ако е четен => към спестяванията += годините, които навършва * 5 - 1лв. (1 лев взима брат й)
                    //money += birthday * 5 - 1;
                //else
                    //==> ако e нечетен=>  към спестяванията += единична цена на играчка 
                    //money += toyprice;
           // }

            //4. проверяваме дали спестените пари са достатъчни, за да си купи пералня
           // if (money >= washingmachine)
               // console.writeline($"yes! {money - washingmachine:f2}");
            //else
                //console.writeline($"no! {washingmachine - money:f2}");
        }
    }
}