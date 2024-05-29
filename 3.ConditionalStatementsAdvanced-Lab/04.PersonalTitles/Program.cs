namespace _04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
              //   Да се напише конзолна програма, която прочита възраст(реално число) и пол('m' или 'f')
              double age = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            if (symbol == 'm')
            {
                //· "Mr." – мъж(пол 'm') на 16 или повече години
                if (age>= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else  //· "Master" – момче(пол 'm') под 16 години
                {
                    Console.WriteLine("Master");
                }
            }
            else if (symbol == 'f')
            {
                //· "Ms." – жена(пол 'f') на 16 или повече години
                if (age>= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else  
                {
                    Console.WriteLine("Miss");
                }
                //· "Miss" – момиче(пол 'f') под 16 годин
            }
        }
    }
}