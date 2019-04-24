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

    /// <summary>
    /// Queue implementation using Linked List
    /// </summary>
    public class QueueUsingLinkedList
    {
        /// <summary>
        /// The list is an integer instance of the Linked List
        /// </summary>
        private LinkedList<int> list = new LinkedList<int>();

        public LinkedList<int> EnQueue(List<int> list1, int number)
        {
            try
            {
                ////Add the data into the linked list
                list = list.AddLastIntoLinkedList(list, list1, number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }

        public LinkedList<int> DeQueue(LinkedList<int> list1, List<int> list)
        {
            try
            {
                int number;

                ////remove top element from the linked list
                number = list1.RemoveFirstLinkedList();

                //// add that removed node from 
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
