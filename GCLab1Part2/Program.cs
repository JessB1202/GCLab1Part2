using System;

namespace GCLab1Part2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //assinging varibles
            DateTime startDate, endDate; 

            //Asking the user for dates
            Console.WriteLine("Please enter a start date, YYYY,MM,DD, please include the commas.");
            startDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please enter an end date, YYYY,MM,DD, please include the commas.");
            endDate = Convert.ToDateTime(Console.ReadLine());

            //Confirmation of input
            Console.WriteLine(startDate);
            Console.WriteLine(endDate);

            //Calculating the difference in dates
            TimeSpan diffDate = endDate - startDate;

            Console.WriteLine(diffDate);

            // Difference in days
            Console.WriteLine(diffDate.Days);

            // Difference in hours
            Console.WriteLine(diffDate.Hours + (diffDate.Days * 24));

            Console.WriteLine(diffDate.Minutes);
        }
    }
}
