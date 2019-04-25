// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramNumberUsingStack.cs" company="Bridgelabz">
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
    /// Print prime anagram numbers using stack
    /// </summary>
    public class PrimeAnagramNumberUsingStack
    {
        /// <summary>
        /// The prime list is a list to store prime numbers
        /// </summary>
        internal static List<int> PrimeList = new List<int>();

        /// <summary>
        /// The anagram number list is to store anagram numbers
        /// </summary>
        internal static List<int> AnagramNumberList = new List<int>();

        /// <summary>
        /// The stack list is an instance of the stack implemented using linked list
        /// </summary>
        internal StackUsingLinkedList StackList = new StackUsingLinkedList();

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
                        ////if anagram then add to list
                        if (Utility<int>.Anagram(PrimeList[i], PrimeList[j]))
                        {
                            AnagramNumberList.Add(PrimeList[i]);
                        }
                    }
                }

                ////Push anagram numbers into the stack
                foreach (int number in AnagramNumberList)
                {
                    this.LinkedListObject = this.StackList.PushIntoStack(AnagramNumberList, number);
                }

                ////Pop anagram numbers from stack
                this.LinkedListObject = this.StackList.PopFromStack(this.LinkedListObject, AnagramNumberList);

                ////print the stack elements after pop operation
                Console.WriteLine("\nPrime Anagram numbers popped from the stack are :  ");
                this.LinkedListObject = this.LinkedListObject.PrintLinkedList(this.LinkedListObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
