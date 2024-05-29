namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOfStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string score = Console.ReadLine();

            double roomForOnePerson = 18.00;
            double apartment = 25.00;
            double presidentAp = 35.00;


            int nightsOfStay = daysOfStay - 1;
            double roomForOnePersonPrice = roomForOnePerson * nightsOfStay;
            double apartmentPrice = apartment * nightsOfStay;
            double presidentApPrice = presidentAp * nightsOfStay;

            switch (roomType)
            {
                case "apartment":

                    if (daysOfStay < 10)

                        apartmentPrice *= 0.70;

                    else if (daysOfStay >= 10 && daysOfStay <= 15)

                        apartmentPrice *= 0.65;

                    else if (daysOfStay > 15)

                        apartmentPrice *= 0.50;

                    if (score == "positive")
                    {
                        double final = apartmentPrice + apartmentPrice * 0.25;
                        Console.WriteLine($"{final:f2}");
                    }
                    else if (score == "negative")
                    {
                        double final = apartmentPrice - apartmentPrice * 0.10;
                        Console.WriteLine($"{final:f2}");
                    }

                    break;


                case "president apartment":

                    if (daysOfStay < 10)

                        presidentApPrice *= 0.90;

                    else if (daysOfStay >= 10 && daysOfStay <= 15)

                        presidentApPrice *= 0.85;

                    else if (daysOfStay > 15)

                        presidentApPrice *=0.80;

                    if (score == "positive")
                    {
                        double final = presidentApPrice + presidentApPrice * 0.25;
                        Console.WriteLine($"{final:f2}");
                    }
                    else if (score == "negative")
                    {
                        double final = presidentApPrice - presidentApPrice * 0.10;
                        Console.WriteLine($"{final:f2}");
                    }
                    break;

                case "room for one person":
                    if (score == "positive")
                    {
                        double final = roomForOnePersonPrice + roomForOnePersonPrice * 0.25;
                        Console.WriteLine($"{final:f2}");
                    }
                    else if (score == "negative")
                    {
                        double final = roomForOnePersonPrice - roomForOnePersonPrice * 0.10;
                        Console.WriteLine($"{final:f2}");
                    }

                    break;
            }
        }
    }
}