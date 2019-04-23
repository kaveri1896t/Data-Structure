// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DequeOperation.cs" company="Bridgelabz">
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
    /// Prime numbers stored in 2D array
    /// </summary>
    public class Prime2DArray
    {
        /// <summary>
        /// The prime numbers array
        /// the first index gives the number of blocks like 0-100, 101-200 and so on.
        /// the second index gives the number of prime numbers present in each range
        /// </summary>
        public static int[,] PrimeNumberArray = new int[10, 25];

        /// <summary>
        /// Prime numbers checker
        /// </summary>
        public static void Prime2DOperation()
        {
            try
            {
                Console.WriteLine("Prime 2D array\n");

                ////insert prime numbers into the prime number array
                int[,] PrimeNumberArray = Utility<int>.InsertIntoPrimeArray(Prime2DArray.PrimeNumberArray);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        ////print the prime numbers
                        Console.Write(PrimeNumberArray[i, j] + "  ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }
    }
}