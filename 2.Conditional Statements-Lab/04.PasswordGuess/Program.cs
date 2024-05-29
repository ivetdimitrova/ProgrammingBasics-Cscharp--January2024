namespace PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vyvejdame parola ot konzolata
            string password = Console.ReadLine();
            // Parolata s koqto trqbva da syvpadne e "s3cr3t!P@ssw0rd
            //proberqvame dali syvpada
            if(password == "s3cr3t!P@ssw0rd")
            // ako syvpada trqbva da izleze "Welcome
            Console.WriteLine("Welcome");
            else
            // ako ne syvpada izliza "Wrong password!"
            Console.WriteLine("Wrong password!");
        }
    }
}