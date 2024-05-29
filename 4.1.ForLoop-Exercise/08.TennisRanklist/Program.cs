namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VHOD
            //broi turniri v koito e uchastval
            int tournaments = int.Parse(Console.ReadLine());
            // nachalen broi tochki
            int startingPoints = int.Parse(Console.ReadLine());

            //TQLO NA PROGRAMATA
            //promenliva v koqto da sybirame rezultata
            //kato vyrviq hte go syberem s nachalnite tochki
            int allPoints = startingPoints;
            int win = 0;
            //for
            for(int i = 0; i< tournaments;i++ )
            {
                //== dostognat etap ot turnira n 
                string stage = Console.ReadLine();
                switch (stage)
                {
                    // ===W - ако е победител получава 2000 точки
                    case "W":
                        allPoints+=2000;
                        win++;
                        break;
                    //====F - ако е финалист получава 1200 точки
                    case "F":
                        allPoints+=1200;
                        break;
                    //====SF - ако е полуфиналист получава 720 точки
                    case "SF":
                        allPoints+= 720;
                        break;
                   
                }

            }

            //IZHOD
            Console.WriteLine($"Final points: {allPoints}");
            //sredno kolko tochki peqeli na turnirite(obh broi na igraniturniri - 
            // nachalniq broi toqki) / na broq turniri
            Console.WriteLine($"Average points: {(allPoints - startingPoints)/tournaments}");
            // kolko procenta pecheli vkarvame edna promenliva za da vidim kolko 
            // systezaniq e spechelil(broq specheleni/ vs turniri*100)%
            Console.WriteLine($"{(double)win/tournaments*100:f2}%");
        }
    }
}