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
        internal static string[,] primeAnagramArray = new string[10, 13];

        //created  ArrayList object primeList
        internal static List<int> primeList = new List<int>();

        //created ArrayList object anagramList
        internal static List<int> anagramNumberList = new List<int>();

        ////this method will check number is prime or not if yes then check for Anagram
        public static void PrimeAnagramNumbers()
        {
            ////Add prime numbers to list
            for (int i = 0; i < 1000; i++)
            {
                if (Utility<int>.Prime(i) == 0)
                {
                    primeList.Add(i);
                }
            }

            ////Add anagram numbers to list
            for (int i = 0; i < primeList.Count; i++)
            {
                for (int j = i + 1; j < primeList.Count; j++)
                {
                    if (Anagram(primeList[i], primeList[j]))
                    {
                        anagramNumberList.Add(primeList[i]);
                        Console.Write(primeList[i]+" ");
                    }
                }
            }

            //calling to storeElement()
            PrimeAnagram2DArray.StoreElement();
           
        }

        //this method is used for store elements in primeAnagramArray.
        public static void StoreElement()
        {
            try
            {
                primeAnagramArray = Utility<int>.InsertInto2DPrimeArray(primeAnagramArray, anagramNumberList);
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        Console.Write(primeAnagramArray[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
            }
        }
        
        //this method checks number is prime or not.
        public static bool Anagram(int n1, int n2)
        {
            int[] n1count = Counting(n1);
            int[] n2count = Counting(n2);
            for (int i = 0; i < n2count.Length; i++)
            {
                //if count of two numbers are not equal then 
                if (n1count[i] != n2count[i])
                {
                    return false;
                }
            }
            return true;
        }
        //this method is used for counting the digits of number.
        private static int[] Counting(int n1)
        {
            int[] count = new int[10];
            int temp = n1;
            while (temp != 0)
            {
                int rem = temp % 10;
                count[rem]++;
                temp = temp / 10;
            }
            return count;
        }

        //main method of proggram.
        public static void PrimeAnagramFunction()
        {
            Console.WriteLine("Prime Anagram Numbers 0-1000 :");
            PrimeAnagram2DArray.PrimeAnagramNumbers();
        }
    }
}
