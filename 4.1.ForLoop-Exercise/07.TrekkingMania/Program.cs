namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int allMembers = 0;
            int membersForMusala = 0;
            int membersForMonblan = 0;
            int membersForKilimagjaro = 0;
            int membersForK2 = 0;
            int membersForEverest = 0;
            //int membersCount = 0;
            for(int i = 0; i < groupsCount; i++) 
            { 
               int members = int.Parse((Console.ReadLine()));
                allMembers += members;

                if(members<= 5)
                {
                    membersForMusala += members;
                }
                else if(members<= 12) 
                { 
                   membersForMonblan += members;
                }
                else if (members <=25 ) 
                { 
                   membersForKilimagjaro += members;
                }
                else if (members <= 40)
                {
                    membersForK2 += members;
                }
                else if(members >=41)
                {
                    membersForEverest+= members;
                }
            }
            Console.WriteLine($"{(double)membersForMusala/allMembers*100:f2}%");
            Console.WriteLine($"{(double)membersForMonblan/allMembers*100:f2}%");
            Console.WriteLine($"{(double)membersForKilimagjaro/allMembers*100:f2}%");
            Console.WriteLine($"{(double)membersForK2/allMembers*100:f2}%");
            Console.WriteLine($"{(double)membersForEverest/allMembers*100:f2}%");

        }
    }
}