using System;

namespace GCLab1Part2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //assinging varibles
            string inputStart, inputEnd;
            DateTime startDate, endDate;
            int diffDays, diffHours, diffMins;

            //Asking the user for start date
            Console.WriteLine("Please enter a start date, MM,DD,YYYY. Please include the commas.");
            inputStart = Console.ReadLine();

            // Validation of start date
            while (!DateTime.TryParse(inputStart, out startDate))
            {
                Console.WriteLine("The start date you entered is invalid. Please input a valid start date.");
                inputStart = Console.ReadLine();
            }

            // Asking the user for end date
            Console.WriteLine("Please enter an end date, MM,DD,YYYY. Please include the commas.");
            inputEnd = Console.ReadLine();

            //Validation of end date
            while (!DateTime.TryParse(inputEnd, out endDate))
            {
                Console.WriteLine("The end date you entered is invalid. Please input a valid end date.");
                inputEnd = Console.ReadLine();
            }

            //Confirming with user the start and end dates
            Console.WriteLine();
            Console.WriteLine("The start date you entered is {0}.", startDate.Date);
            Console.WriteLine("The end date you entered is {0}.", endDate.Date);
            Console.WriteLine();

            //Calculating the difference in dates
            TimeSpan diffDate = endDate - startDate;

            // Difference in days
            diffDays = diffDate.Days;
            Console.WriteLine("The number of days between {0} and {1} are {2} days.", startDate.Date, endDate.Date, Math.Abs(diffDays));
            Console.WriteLine();

            // Difference in hours
            diffHours = diffDate.Hours + (diffDays * 24);
            Console.WriteLine("The number of hours between {0} and {1} are {2} hours.", startDate.Date, endDate.Date, Math.Abs(diffHours));
            Console.WriteLine();

            // Difference in minutes
            diffMins = diffDate.Minutes + (diffHours * 60);
            Console.WriteLine("The number of minutes between {0} and {1} are {2} minutes.", startDate.Date, endDate.Date, Math.Abs(diffMins));
        }
    }
}
