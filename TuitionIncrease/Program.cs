using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncrease
{
    class Program
    {
        static void Main(string[] args)
        {//Shaun Poweshiek, referenced: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for

            //Establish variables to be used in tuition calculations:
            double originalTuition = 12000;
            const double tuitionIncreasePercentage = 0.05;
            const double tuitionIncreaseTimeFrame = 7;
            double projectedTuitionAmount = originalTuition;

            //Utilize FOR loop to caluclate and display incremental tuition increases over 7 years (see ref link above):
            for (int i = 1; i <= tuitionIncreaseTimeFrame; i++)
            {
            //Calculate the projected tution fee per year:
            projectedTuitionAmount = originalTuition + originalTuition * tuitionIncreasePercentage;

                //Utilized String.Format Method, ref: https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.8
                string projectedTuitionAmountAsAString = string.Format("{0:C}", projectedTuitionAmount);

                //Display information to the console for the user:
                Console.WriteLine($"The tution after year {i} will be {projectedTuitionAmountAsAString}");
                originalTuition = projectedTuitionAmount;
            }

            Console.ReadKey();


        }
    }
}
