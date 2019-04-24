// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramNumberUsingQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PrimeAnagramNumberUsingQueue
    {
        /// <summary>
        /// The stack list is an instance of the stack implemented using linked list
        /// </summary>
        internal QueueUsingLinkedList queueList = new QueueUsingLinkedList();

        /// <summary>
        /// The linked list object is an instance of the Linked List
        /// </summary>
        internal LinkedList<int> linkedListObject = new LinkedList<int>();

        /// <summary>
        /// The prime list is a list to store prime numbers
        /// </summary>
        internal static List<int> primeList = new List<int>();

        /// <summary>
        /// The anagram number list is to store anagram numbers
        /// </summary>
        internal static List<int> anagramNumberList = new List<int>();

        /// <summary>
        /// Prints the prime anagram numbers.
        /// This is the method where execution starts
        /// </summary>
        public void PrintPrimeAnagram()
        {
            try
            {
                ////Add prime numbers to list
                for (int i = 2; i < 1000; i++)
                {
                    ////Check if prime or not
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
                        if (Utility<int>.Anagram(primeList[i], primeList[j]))
                        {
                            anagramNumberList.Add(primeList[i]);
                        }
                    }
                }

                ////Push anagram numbers into the stack
                foreach (int number in anagramNumberList)
                {
                    linkedListObject = queueList.EnQueue(anagramNumberList, number);
                }

                linkedListObject = queueList.DeQueue(linkedListObject, anagramNumberList);

                Console.WriteLine("\nPrime Anagram numbers Dequeued from queue are :  ");
                linkedListObject = linkedListObject.PrintLinkedList(linkedListObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
