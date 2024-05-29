
namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цена на екскурзията - реално число
            double moneyForTrip = double.Parse(Console.ReadLine());
            //Брой пъзели - цяло число - цена 2.60
            int countPuzzle = int.Parse(Console.ReadLine());
            //Брой говорещи кукли -цяло число- цена 3.00
            int countTalkingDoll = int.Parse(Console.ReadLine());
            //Брой плюшени мечета -цяло число- цена 4.10
            int countTeddyBears = int.Parse(Console.ReadLine());
            //Брой миньони - цяло число- цена 8.20
            int countMinions = int.Parse(Console.ReadLine());
            //Брой камиончета - цяло число- цена 2.00
            int countTrucks= int.Parse(Console.ReadLine());

            int countAllToys = countPuzzle + countTalkingDoll+ countTeddyBears + countMinions + countTrucks;

            double priceForAllToys = (countPuzzle * 2.60)+(countTalkingDoll * 3.00)+(countTeddyBears * 4.10)+(countMinions*8.20)+(countTrucks*2.00);
            // ако поръчаните играчки са 50 или повецхе се прави отстъпка 25%
            double priceWithDiscount = 0;
            double priceForMagazine = 0;
            double pechalba = 0;
            if (countAllToys >= 50)
            {
                priceWithDiscount = priceForAllToys - (priceForAllToys * 0.25);
                priceForMagazine = priceWithDiscount *0.1;
                pechalba = priceWithDiscount - priceForMagazine;
            }
            else
            {
                // трябва да се дадат 10% за наем за магазина
                priceForMagazine = priceForAllToys *0.1;
                pechalba = priceForAllToys - priceForMagazine;
            }

            if (pechalba > moneyForTrip)
            {
                // да се пресметнат дали парите са й достатъчни- "Yes! {оставащите пари} lv left."
                double lastmoney = pechalba - moneyForTrip;
                Console.WriteLine($"Yes! {lastmoney:f2} lv left.");
            }
            else
            {
                // ако не са й -"Not enough money! {недостигащите пари} lv needed."
                double neededmoney = moneyForTrip - pechalba;
                Console.WriteLine($"Not enough money! {neededmoney:f2} lv needed.");
            }


        }
    }
}