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
        static String[,] primeAnagramArray = new String[13, 13];

        //created  ArrayList object primeList
        static List<int> primeList = new List<int>();
        //created ArrayList object anagramList
        static List<int> anagramList = new List<int>();

        ////this method will check number is prime or not if yes then check for Anagram
        public static void PrimeAnagram()
        {
            bool flag = true;
            for (int i = 1; i <= 1000; i++)
            {
                flag = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        //if flag== false then its not a prime no.
                        flag = false;
                        break;
                    }
                }
                if (flag && i > 1)
                {

                    primeList.Add(i);
                }
            }

            for (int i = 0; i < primeList.Count; i++)
            {
                for (int j = i + 1; j < primeList.Count; j++)
                {
                    if (Anagram(primeList[i], primeList[j]))//anagram calling 
                    {
                        //System.out.println(primeList.get(i)+" "+primeList.get(j));
                        anagramList.Add(primeList[i]);
                    }
                }
            }
            //calling to storeElement()
            PrimeAnagram2DArray.StoreElement();
            // calling to display()
            PrimeAnagram2DArray.Display();
        }

        //this method is used for store elements in primeAnagramArray.
        public static void StoreElement()
        {
            try
            {
                int index = 0;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {

                        primeAnagramArray[i, j] = primeList[index].ToString();
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
            }
        }

        //this method is used for display elements from primeAnagramArray.
        public static void Display()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(primeAnagramArray[i, j] + " ");
                }
                Console.Write("\n");
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
        public static void Primefunction()
        {
            Console.WriteLine("Prime Anagram Numbers 0-1000 :");
            PrimeAnagram2DArray.PrimeAnagram();
        }
    }
}
