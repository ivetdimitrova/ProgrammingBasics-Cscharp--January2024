namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double land = double.Parse(Console.ReadLine());
            double priceWhoutDiscount = land * 7.61;
            double discount = priceWhoutDiscount * 0.18;
            double priceWithDiscount = priceWhoutDiscount - discount;
            Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}