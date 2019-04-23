// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calendar.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calendar class to print the Calendar of given Month and Year
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Display Calendar is a method that contains monthsOfYear and number of days in each month
        /// Prints the Calendar in format
        /// </summary>
        public static void DisplayCalendar()
        {
            int month;
            int year;
            do
            {
                ////Take Month as a input from user
                Console.WriteLine("Enter the month (Jan = 1 to Dec = 12) in (mm) format : ");
                month = Convert.ToInt32(Console.ReadLine());
            }
            while (month < 1 || month > 12);
            do
            {
                ////Take Year as a input from user
                Console.WriteLine("Enter the year in (yyyy) format : ");
                year = Convert.ToInt32(Console.ReadLine());
            }
            while (year < 1000 || year > 9999);

            //// store monthsOfYear in string array
            string[] monthsOfYear = { string.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //// store number of days in each month
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //// check for leap year
            //// if leap year then february have 29 days 
            //// update 
            if (month == 2 && Utility<int>.IsLeapYear(year))
            {
                days[month] = 29;
            }

            //// print calendar header
            Console.WriteLine("\t\t\t" + monthsOfYear[month] + "\t" + year);
            Console.WriteLine("S\tM\tTu\tW\tTh\tF\tS");

            //// Get starting week day of given Month and Year
            int day = Utility<int>.GetDay(month, 1, year);

            //// Print the dates in calendar format
            for (int j = 0; j < day; j++)
            {
                //// Check for the first empty days and print space 
                Console.Write(" \t");
            }

            for (int i = 1; i <= days[month]; i++)
            {
                ////Print dates from first 
                Console.Write(i + "\t");

                ////Check if it reached at Saturday or end of month
                if (((i + day) % 7 == 0) || (i == days[month]))
                {
                    Console.WriteLine();
                }
            }
        }
    }
}