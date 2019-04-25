// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForHashing.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Takes input for hashing function and call the hashing function
    /// </summary>
    public class InputForHashing
    {
        /// <summary>
        /// The input hash is an input list to be stored in Hash Array
        /// </summary>
        internal List<int> InputHash = new List<int>();

        /// <summary>
        /// The hash array to store elements
        /// </summary>
        internal int[,] HashArray = new int[10, 10];

        /// <summary>
        /// Call to the hashing function.
        /// </summary>
        public void CallHashingFunction()
        {
            ////read numbers from file
            string text = File.ReadAllText(Utility<int>.GetIntegerInputPath());
            string[] string1 = text.Split("\n");
            foreach (string string2 in string1)
            {
                ////add into list
                this.InputHash.Add(Convert.ToInt32(string2));
            }

            HashingFunction hash = new HashingFunction();
            HashArray = hash.HashFunction(this.InputHash);

            Console.WriteLine("Array Elements : \n");
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(HashArray[i,j] + "  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nEnter the number to search into the Hash Array : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNumber found at "+(hash.SearchIntoHashArray(number)+1)+" index in Hash Table...");
        }
    }
}
