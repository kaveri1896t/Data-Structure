﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortedLinkedList.cs" company="Bridgelabz">
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
    /// Sorted Linked List
    /// </summary>
    public class SortedLinkedList
    {
        /// <summary>
        /// The head is an instance of the node class which points to the first node into the linked list
        /// </summary>
        internal NewNode<int> Head;

        /// <summary>
        /// Adds the node into sorted linked list.
        /// </summary>
        /// <param name="list">The list is an instance of the Linked List.</param>
        /// <param name="data">The data is to be get added into list.</param>
        /// <returns>sorted linked list</returns>
        public SortedLinkedList AddIntoSortedLinkedList(SortedLinkedList list, int data)
        {
            NewNode<int> newNode = new NewNode<int>();
            newNode.NodeData = data;
            newNode.Next = null;
            NewNode<int> currentNode = list.Head;

            //// check if required node is the Head node
            if (list.Head == null)
            {
                ////
                newNode.Next = list.Head.Next;
                list.Head.Next = newNode;
                return list;
            }

            ////Traverse till end
            while (currentNode != null)
            {
                if (list.Head.NodeData > data)
                {
                    newNode.Next = list.Head;
                    list.Head = newNode;
                }

                ////Compare the position of the new node to be added into the list
                if (currentNode.NodeData < data && currentNode.Next.NodeData > data)
                {
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                }

                currentNode = currentNode.Next;
            }

            return list;
        }

        /// <summary>
        /// Sorts the linked list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns>sorted linked list</returns>
        public SortedLinkedList SortLinkedList(SortedLinkedList list)
        {
            NewNode<int> currentNode = list.Head;

            NewNode<int> tempNode = new NewNode<int>();

            ////Traverse till end
            while (currentNode != null)
            {
                NewNode<int> currentNode1 = currentNode.Next;

                while (currentNode1 != null)
                {
                    //// check if required node is the Head node
                    if (list.Head == null)
                    {
                        Console.WriteLine("\nEmpty List...");
                    }

                    ////if first is greater then swap 
                    if (currentNode.NodeData > currentNode1.NodeData)
                    {
                        ////Swap the elements 
                        tempNode.NodeData = currentNode.NodeData;
                        currentNode.NodeData = currentNode1.NodeData;
                        currentNode1.NodeData = tempNode.NodeData;
                    }

                    //// break the links
                    currentNode1 = currentNode1.Next;
                }

                currentNode = currentNode.Next;
            }

            return list;
        }

        /// <summary>
        /// Adds the into linked list.
        /// </summary>
        /// <param name="list">The list is an instance of Linked List.</param>
        /// <param name="data">The data is to be added into the Linked List.</param>
        /// <returns>updated list</returns>
        public SortedLinkedList AddLastIntoLinkedList(SortedLinkedList list, int data)
        {
            NewNode<int> newNode = new NewNode<int>();
            newNode.NodeData = data;
            newNode.Next = null;
            if (list.Head == null)
            {
                list.Head = newNode;
            }
            else
            {
                //// The current node is temporary node for traversing into Linked List
                NewNode<int> currentNode = list.Head;

                // Traverse till the end of the list....
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                // Add new node as the Next node to the last node.
                currentNode.Next = newNode;
            }

            return list;
        }

        /// <summary>
        /// Removes the first node from linked list.
        /// </summary>
        /// <param name="list">The list is as instance of the Linked List.</param>
        /// <returns>Sorted  Linked List</returns>
        public SortedLinkedList RemoveFirstFromLinkedList(SortedLinkedList list)
        {
            NewNode<int> currentNode = list.Head;

            //// check if required node is the Head node
            if (currentNode == list.Head)
            {
                ////delete the Head
                list.Head = currentNode.Next;
                GC.Collect();
            }

            return list;
        }

        /// <summary>
        /// Removes the last node from linked list.
        /// </summary>
        /// <param name="list">The list is an instance of the Linked List.</param>
        /// <returns>Sorted Linked List</returns>
        public SortedLinkedList RemoveLastFromLinkedList(SortedLinkedList list)
        {
            ////check if Linked List is present or not
            if (list.Head == null)
            {
                Console.WriteLine("\nEmpty Linked List...");
            }
            else
            {
                //// The current node is temporary node for traversing into Linked List
                NewNode<int> currentNode = list.Head;

                // Traverse till the end of the list....
                while (currentNode.Next.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                // Add new node as the Next node to the last node.
                currentNode.Next = null;

                //// Free the memory space aquired by node
                GC.Collect();
            }

            return list;
        }

        /// <summary>
        /// Removes specific node from linked list.
        /// </summary>
        /// <param name="list">The list is an instance of the Linked List.</param>
        /// <param name="data">The data to be removed from linked list.</param>
        /// <returns>Sorted Linked List</returns>
        public SortedLinkedList RemoveAtPositionFromLinkedList(SortedLinkedList list, int data)
        {
            NewNode<int> currentNode = list.Head;

            ////Traverse till end
            while (currentNode != null)
            {
                //// check if required node is the Head node
                if (currentNode == list.Head && list.Head.NodeData.Equals(data))
                {
                    ////if found then delete the Head
                    list.Head = currentNode.Next;
                    GC.Collect();
                    return list;
                }
                else if (currentNode.Next.NodeData.Equals(data))
                {
                    currentNode.Next = currentNode.Next.Next;
                    return list;
                }
                else
                {
                    //// break the links
                    currentNode = currentNode.Next;
                }
            }

            return list;
        }

        /// <summary>
        /// Searches the node into the linked list.
        /// </summary>
        /// <param name="list">The list is an instance of the Linked List.</param>
        /// <param name="data">The data to be searched.</param>
        /// <returns>Sorted list</returns>
        public bool SearchIntoLinkedList(SortedLinkedList list, int data)
        {
            //// The current node is temporary node for traversing into Linked List
            NewNode<int> currentNode = list.Head;
            while (currentNode != null)
            {
                if (object.Equals(currentNode.NodeData, data))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        /// <summary>
        /// Prints the linked list.
        /// </summary>
        /// <param name="list">The list is an instance of linked list.</param>
        /// <returns>sorted list</returns>
        public SortedLinkedList PrintLinkedList(SortedLinkedList list)
        {
            //// The current node is temporary node for traversing into Linked List
            NewNode<int> currentNode = list.Head;
            if (list.Head == null)
            {
                Console.WriteLine("\nEmpty Linked List...");
            }
            else
            {
                Console.WriteLine("Linked List :\n");
                Console.Write("Head");

                // Traverse till the end of the list....
                while (currentNode != null)
                {
                    ////print the data of each node
                    Console.WriteLine(" -> " + currentNode.NodeData);
                    currentNode = currentNode.Next;
                }
            }

            return list;
        }
    }
}
