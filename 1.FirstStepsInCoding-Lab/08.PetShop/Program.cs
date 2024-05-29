namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            double priceForDogsFood =  dogsFood* 2.50;
            int catsFood = int.Parse(Console.ReadLine());
            double priceForCatsFood = catsFood * 4;
            double price = priceForCatsFood + priceForDogsFood;
            Console.WriteLine($"{price} lv.");
        }
    }
}