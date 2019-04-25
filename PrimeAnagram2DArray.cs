// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagram2DArray.cs" company="Bridgelabz">
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
    /// Find prime anagram numbers and store into 2D array
    /// </summary>
    public class PrimeAnagram2DArray
    {
        /// <summary>
        /// The prime anagram array to store prime anagram numbers
        /// </summary>
        internal static string[,] PrimeAnagramArray = new string[13, 13];

        /// <summary>
        /// The prime list is a list to store prime numbers
        /// </summary>
        internal static List<int> PrimeList = new List<int>();

        /// <summary>
        /// The anagram number list is to store anagram numbers
        /// </summary>
        internal static List<int> AnagramNumberList = new List<int>();

        /// <summary>
        /// this method will check number is prime or not if yes then check for Anagram.
        /// </summary>
        public static void PrimeAnagramNumbers()
        {
            try
            {
                ////Add prime numbers to list
                for (int i = 2; i < 1000; i++)
                {
                    if (Utility<int>.Prime(i) == 0)
                    {
                        PrimeList.Add(i);
                    }
                }

                ////Add anagram numbers to list
                for (int i = 0; i < PrimeList.Count; i++)
                {
                    for (int j = i + 1; j < PrimeList.Count; j++)
                    {
                        if (Utility<int>.Anagram(PrimeList[i], PrimeList[j]))
                        {
                            AnagramNumberList.Add(PrimeList[i]);
                        }
                    }
                }

                AnagramNumberList.Sort();

                ////calling to store Element function
                PrimeAnagram2DArray.StoreElement();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// this method is used to store elements in PrimeAnagramArray.
        /// </summary>
        public static void StoreElement()
        {
            ////Store prime anagram numbers into the 2D array
            try
            {
                int index = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        PrimeAnagramArray[i, j] = AnagramNumberList[index].ToString();
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Empty);
            }

            ////Print the 2D array having Prime Anagram Number
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Console.Write(PrimeAnagramArray[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Empty);
            }
        }

        /// <summary>
        /// call to the Prime anagram function.
        /// </summary>
        public static void PrimeAnagramFunction()
        {
            try
            {
                Console.WriteLine("Prime Anagram Numbers 0-1000 :");
                PrimeAnagram2DArray.PrimeAnagramNumbers();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
