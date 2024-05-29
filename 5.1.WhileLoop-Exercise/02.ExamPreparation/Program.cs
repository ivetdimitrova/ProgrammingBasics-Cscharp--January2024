using System.Diagnostics;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int badGrades = int.Parse(Console.ReadLine());
            
            int averageGrade = 0;
            string lastExercise = string.Empty;
            int countBadGrades = 0;
            int allExercise = 0;
                string exercise = Console.ReadLine(); 
            while (true)
                
            { 
                if(exercise == "Enough")
                {
                    
                    Console.WriteLine($"Average score: {(double)averageGrade/allExercise:f2}");
                   
                    Console.WriteLine($"Number of problems: {allExercise}");
                    
                    Console.WriteLine($"Last problem: {lastExercise}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                averageGrade += grade;
                allExercise++;
                if(grade <= 4)
                {
                    countBadGrades++;
                }
                
                if(countBadGrades == badGrades)
                {
                   
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    break;
                }
                lastExercise= exercise;

                exercise = Console.ReadLine();  
            
            }
        }
    }
}