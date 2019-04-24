// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StackUsingLinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StackUsingLinkedList
    {
        /// <summary>
        /// The list is an integer instance of the Linked List
        /// </summary>
        private LinkedList<int> list = new LinkedList<int>();
        
        /// <summary>
        /// Pushes the number into the stack.
        /// </summary>
        /// /// <param name="list1">Is an instance of Linked List.</param>
        /// <param name="number">The number is to be pushed into the stack.</param>
        /// <returns>updated list</returns>
        public LinkedList<int> PushIntoStack(List<int> list1, int number)
        {
            try
            {
                ////Add the data into the linked list
                list = list.AddFirstIntoLinkedList(list, list1, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }

        /// <summary>
        /// Pop top element from stack.
        /// </summary>
        /// <param name="list1">The list1 is an integer instance of the Linked List.</param>
        /// <returns>Updated List</returns>
        public LinkedList<int> PopFromStack(LinkedList<int> list1,List<int> list)
        {
            try
            {
                int number;

                ////remove top element from the linked list
                number = list1.RemoveFirstLinkedList();

                //// add that removed node from stack
                list1.AddFirstIntoLinkedList(list1,list, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list1;
        }

    }
}
