namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            int time = int.Parse(Console.ReadLine());

            double apartment = 0;
            double studio = 0;
            double priceForStudio = 0;
            double priceForApartment = 0;
            //double studio1 = 0;
            //double 1 = 0;
            switch (period)
            {     
                
                case "May":
                case "October":
                    apartment =  65;
                        studio = 50;
                    if(time >= 14)
                    {
                         studio = studio - (studio *  0.3);
                        //studio1 = time * studio;

                        apartment = apartment - (apartment * 0.1);
                       // apartmen
                    }
                    else if(time >= 7)
                    {
                        studio = studio - (studio *  0.05);
                       //priceForStudio = time * studio;
                       
                    }
                    break;
                case "June":
                case "September":
                    apartment =  68.70;
                    studio =  75.20;
                   
                    if (time >= 14)
                    {
                        studio = studio - (studio *  0.2);
                        //priceForStudio = time * studio;
                       
                        
                           apartment = apartment - (apartment * 0.1);
                        
                    }
                    break;
                case "July":
                    case "August":
                    apartment = 77;
                    studio =  76;
                    if (time >= 14)
                    {
                        apartment = apartment - (apartment * 0.1);
                    }
                    break;
              
            }
                    priceForApartment = time * apartment;
            priceForStudio = time * studio;
                    
            Console.WriteLine($"Apartment: {priceForApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");

        }
    }
}