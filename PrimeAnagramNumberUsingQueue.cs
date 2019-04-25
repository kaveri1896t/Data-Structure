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

    /// <summary>
    /// Prime anagram numbers using queue
    /// </summary>
    public class PrimeAnagramNumberUsingQueue
    {
        /// <summary>
        /// The anagram number list is to store anagram numbers
        /// </summary>
        internal static List<int> AnagramNumberList = new List<int>();

        /// <summary>
        /// The prime list is a list to store prime numbers
        /// </summary>
        internal static List<int> PrimeList = new List<int>();

        /// <summary>
        /// The stack list is an instance of the stack implemented using linked list
        /// </summary>
        internal QueueUsingLinkedList QueueList = new QueueUsingLinkedList();

        /// <summary>
        /// The linked list object is an instance of the Linked List
        /// </summary>
        internal LinkedList<int> LinkedListObject = new LinkedList<int>();
        
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
                        PrimeList.Add(i);
                    }
                }

                ////Add anagram numbers to list
                for (int i = 0; i < PrimeList.Count; i++)
                {
                    for (int j = i + 1; j < PrimeList.Count; j++)
                    {
                        ////Check if two numbers are anagram or not
                        if (Utility<int>.Anagram(PrimeList[i], PrimeList[j]))
                        {
                            ////if anagram then add into anagram list
                            AnagramNumberList.Add(PrimeList[i]);
                        }
                    }
                }

                ////Push anagram numbers into the stack
                foreach (int number in AnagramNumberList)
                {
                    ////Insert into queue
                    this.LinkedListObject = this.QueueList.EnQueue(AnagramNumberList, number);
                }

                ////Remove from the queue
                this.LinkedListObject = this.QueueList.DeQueue(this.LinkedListObject, AnagramNumberList);

                ////Print the prime anagram numbers
                Console.WriteLine("\nPrime Anagram numbers Dequeued from queue are :  ");
                this.LinkedListObject = this.LinkedListObject.PrintLinkedList(this.LinkedListObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
