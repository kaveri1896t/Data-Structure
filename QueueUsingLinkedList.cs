// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueUsingLinkedList.cs" company="Bridgelabz">
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
    /// Queue implementation using Linked List
    /// </summary>
    public class QueueUsingLinkedList
    {
        /// <summary>
        /// The list is an integer instance of the Linked List
        /// </summary>
        private LinkedList<int> list = new LinkedList<int>();

        /// <summary>
        /// Insert elements into the queue.
        /// </summary>
        /// <param name="list1">The list1 is the list of element.</param>
        /// <param name="number">The number to be inserted into queue.</param>
        /// <returns>updated List</returns>
        public LinkedList<int> EnQueue(List<int> list1, int number)
        {
            try
            {
                ////Add the data into the linked list
                this.list = this.list.AddLastIntoLinkedList(this.list, list1, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this.list;
        }

        /// <summary>
        /// Removes elements from the queue.
        /// </summary>
        /// <param name="list1">The list1 is the instance of the linked list.</param>
        /// <param name="list">The list is the list of elements.</param>
        /// <returns>updated linked list</returns>
        public LinkedList<int> DeQueue(LinkedList<int> list1, List<int> list)
        {
            try
            {
                int number;

                ////remove top element from the linked list
                number = list1.RemoveFirstLinkedList();

                //// add that removed node from 
                list1.AddFirstIntoLinkedList(list1, list, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list1;
        }
    }
}
