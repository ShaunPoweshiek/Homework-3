using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToBurn
{
    class Program
    {
        static void Main(string[] args)
        {//Shaun Poweshiek, reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/while

            //Assign varibles to be used in formula:
            const double calorieBurnRate = 3.9;
            int timeIncrement = 1;
            double caloriesExpended = 0;

            //Obtain expended calorie goal from the user:
            Console.WriteLine("How many calories would you like to burn during this workout? ");
            string calorieGoalAsAString = Console.ReadLine();
            double calorieGoal = Convert.ToDouble(calorieGoalAsAString);

            //Create WHILE loop needed to calculate expended calories per minute and display on console for the user:
            while (caloriesExpended < calorieGoal) //While calories expended are less than calorie goal...keep doing this...
            {
                caloriesExpended = calorieBurnRate * timeIncrement; //(re)calcualte calories expended
                Console.WriteLine($"After {timeIncrement} minute(s), you have burned {caloriesExpended} calories");
                timeIncrement++; //add another minute increment to the total calories expended calculation while still meeting While statement parameters.
            }
            
            Console.ReadKey();
        }
    }
}
