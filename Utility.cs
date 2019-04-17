// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Collection of multiple methods
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Prints the string array.
        /// </summary>
        /// <param name="list">The list.</param>
        public void PrintStringArray(string[] list)
        {
            foreach (string stringtext in list)
            {
                Console.WriteLine(stringtext);
            }
        }

        /// <summary>
        /// Prints the linked list.
        /// </summary>
        /// <param name="list">The list.</param>
        public void PrintLinkedList(LinkedList<string> list)
        {
            foreach (string stringtext in list)
            {
                Console.WriteLine(stringtext);
            }
        }

        /// <summary>
        /// Adds the string into linked list at end.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="str">The string.</param>
        public void AddLastIntoLinkedList(LinkedList<string> list, string str)
        {
            list.AddLast(str);
        }

        /// <summary>
        /// Adds the string into linked list at start.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="str">The string.</param>
        public void AddFirstIntoLinkedList(LinkedList<string> list, string str)
        {
            list.AddFirst(str);
        }

        /// <summary>
        /// Searches the linked list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="instring">The instring.</param>
        /// <returns>True if string found in LinkedList</returns>
        public bool SearchLinkedList(LinkedList<string>list, string instring)
        {
            return list.Contains(instring);
        }

        /// <summary>
        /// Deletes from linked list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="str">The string.</param>
        public void DeleteFromLinkedList(LinkedList<string> list, string str)
        {
            list.Remove(str);
            Console.WriteLine("\nLinked List after deleting the string : ");
            PrintLinkedList(list);
        }

        /// <summary>
        /// Inserts the into linked list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="str">The string.</param>
        public void InsertIntoLinkedList(LinkedList<string> list, string str)
        {
            list.AddLast(str);
            Console.WriteLine("\nLinked List after inserting the string : ");
            PrintLinkedList(list);
        }
    }
}
