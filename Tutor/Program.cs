using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor
{
    class Program
    {
        static void Main(string[] args)
        {//Shaun Poweshiek, reference: https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netframework-4.8

            // "Instantiate random number generator using system-supplied value as seed." - Microsoft (see link above)
            var rand = new Random();

            //Establish two variables for random numbers, 1-50.  (Also reference above MS link for help with this section)
            int randomNumber1 = rand.Next(0, 50);
            int randomNumber2 = rand.Next(0, 50);

            //Simple addition formula using random numbers:
            int correctAnswer = randomNumber1 + randomNumber2;

            //Output math question to the user:
            Console.WriteLine($"{randomNumber1} + {randomNumber2} = ?");

            //Establish user's answer as an integer variable
            string usersAnswerAsAString = Console.ReadLine();
            int userAnswer = Convert.ToInt32(usersAnswerAsAString);

            //If user got answer right, display congrats message:
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("You got it right, GREAT JOB!!!");
            }
            else

            //If user got answer wrong, tell user to try again (utilizied DO-WHILE loop statement)
            do
            {
                Console.WriteLine("Sorry, please try again");
                break;
            }
            while (userAnswer != correctAnswer);

            //Alternate code that did not have a DO-WHILE loop statement...did not use...
            /*
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("You got it right, GREAT JOB!!!");
            }
            else
            {
                Console.WriteLine("Sorry, please try again");
            }*/


            Console.ReadKey();
        }
    }
}
