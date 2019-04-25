// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
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
    /// Linked List Class
    /// </summary>
    /// <typeparam name="T">Generic Type class</typeparam>
    public class LinkedList<T>
    {
        /// <summary>
        /// The Head is pointing to the first node of the Linked List.
        /// </summary>
        internal NewNode<T> Head;

        /// <summary>
        /// Write to file 
        /// </summary>
        /// <returns>String containing Data each node of linked list</returns>
        public string FileWrite()
        {
            string outputString = null;
            try
            {
                NewNode<T> currentNode = this.Head;

                //// traversae till end
                while (currentNode != null)
                {
                    //// add node data into the string
                    outputString += currentNode.NodeData + "\n";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return outputString;
        }

        /// <summary>
        /// Adds the node at first into linked list.
        /// </summary>
        /// <param name="list1">The list1 is an instance of the Linked List.</param>
        /// <param name="list">The list.</param>
        /// <param name="data">The data.</param>
        /// <returns>updated list</returns>
        public LinkedList<T> AddFirstIntoLinkedList(LinkedList<T> list1, List<T> list, T data)
        {
            NewNode<T> newNode = new NewNode<T>();
            newNode.NodeData = data;
            newNode.Next = null;
            try
            {
                if (list1.Head == null)
                {
                    list1.Head = newNode;
                    return list1;
                }
                else
                {
                    newNode.Next = list1.Head;
                    list1.Head = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list1;
        }

        /// <summary>
        /// Adds the last node into linked list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <param name="list1">The list1.</param>
        /// <param name="data">The data.</param>
        /// <returns>updated list</returns>
        public LinkedList<T> AddLastIntoLinkedList(LinkedList<T> list, List<T> list1, T data)
        {
            NewNode<T> newNode = new NewNode<T>();
            newNode.NodeData = data;
            newNode.Next = null;
            try
            {
                if (list.Head == null)
                {
                    list.Head = newNode;
                }
                else
                {
                    //// The current node is temporary node for traversing into Linked List
                    NewNode<T> currentNode = list.Head;

                    // Traverse till the end of the list....
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }

                    // Add new node as the Next node to the last node.
                    currentNode.Next = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }

        /// <summary>
        /// Adds the into linked list.
        /// </summary>
        /// <param name="list">The list is an instance of Linked List.</param>
        /// <param name="data">The data is to be added into the Linked List.</param>
        /// <returns>updated list</returns>
        public LinkedList<T> AddIntoLinkedList(LinkedList<T> list, T data)
        {
            NewNode<T> newNode = new NewNode<T>();
            newNode.NodeData = data;
            newNode.Next = null;
            try
            {
                if (list.Head == null)
                {
                    list.Head = newNode;
                    return list;
                }
                else
                {
                    //// The current node is temporary node for traversing into Linked List
                    NewNode<T> currentNode = list.Head;

                    // Traverse till the end of the list....
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }

                    // Add new node as the Next node to the last node.
                    currentNode.Next = newNode;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }

        /// <summary>
        /// Add new node after the specified node 
        /// </summary>
        /// <param name="list">instance of Linked List</param>
        /// <param name="position">To search the specified node</param>
        /// <param name="data">To be given to new node</param>
        /// <returns>updated list</returns>
        public LinkedList<T> AddAfterNodeIntoLinkedList(LinkedList<T> list, T position, T data)
        {
            NewNode<T> newNode = new NewNode<T>();
            newNode.NodeData = data;
            newNode.Next = null;
            NewNode<T> currentNode = list.Head;
            try
            {
                ////Traverse till end
                while (currentNode != null)
                {
                    //// check if required node is the Head node
                    if (currentNode == list.Head && list.Head.NodeData.Equals(position))
                    {
                        ////
                        newNode.Next = list.Head.Next;
                        list.Head.Next = newNode;
                        return list;
                    }
                    else if (currentNode.NodeData.Equals(position))
                    {
                        newNode.Next = currentNode.Next;
                        currentNode.Next = newNode;
                        return list;
                    }
                    else
                    {
                        //// break the links
                        currentNode = currentNode.Next;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }

        /// <summary>
        /// Remove first node from the Linked List
        /// </summary>
        /// <param name="list">instance of Linked List</param>
        /// <returns>Updated Linked List</returns>
        public LinkedList<T> RemoveFirstFromLinkedList(LinkedList<T> list)
        {
            NewNode<T> currentNode = list.Head;
            try
            {
                //// check if required node is the Head node
                if (currentNode == list.Head)
                {
                    ////delete the Head
                    list.Head = currentNode.Next;
                    GC.Collect();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }

        /// <summary>
        /// Removes the first node from linked list.
        /// </summary>
        /// <returns>Removed Element</returns>
        public T RemoveFirstLinkedList()
        {
            NewNode<T> currentNode = this.Head;
            T data = this.Head.NodeData;
            try
            {
                //// check if required node is the Head node
                if (currentNode == this.Head)
                {
                    ////delete the Head
                    this.Head = currentNode.Next;
                    GC.Collect();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data;
        }

        /// <summary>
        /// Removes the last from linked list.
        /// </summary>
        /// <param name="list">list is an instance of Linked List to access members of list.</param>
        /// <returns>Updated List</returns>
        public LinkedList<T> RemoveLastFromLinkedList(LinkedList<T> list)
        {
            ////check if Linked List is present or not
            if (list.Head == null)
            {
                Console.WriteLine("\nEmpty Linked List...");
            }
            else
            {
                //// The current node is temporary node for traversing into Linked List
                NewNode<T> currentNode = list.Head;
                try
                {
                    //// Traverse till the end of the list....
                    while (currentNode.Next.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }

                    // Add new node as the Next node to the last node.
                    currentNode.Next = null;

                    //// Free the memory space aquired by node
                    GC.Collect();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return list;
        }

        /// <summary>
        /// Remove the node at specific position in the 
        /// </summary>
        /// <param name="list">list is an instance of Linked List to access members of list.</param>
        /// <param name="data">To search the node that need to be deleted.</param>
        /// <returns>Updated Linked List</returns>
        public LinkedList<T> RemoveAtPositionFromLinkedList(LinkedList<T> list, T data)
        {
            NewNode<T> currentNode = list.Head;
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }

        /// <summary>
        /// Prints the linked list data.
        /// </summary>
        /// <param name="list">The list is an instance of Linked List.</param>
        /// <returns>Updated List</returns>
        public LinkedList<T> PrintLinkedList(LinkedList<T> list)
        {
            //// The current node is temporary node for traversing into Linked List
            NewNode<T> currentNode = list.Head;
            if (list.Head == null)
            {
                Console.WriteLine("\nEmpty Linked List...");
            }
            else
            {
                try
                {
                    Console.WriteLine("Linked List :\n");
                    Console.Write("Head");

                    // Traverse till the end of the list....
                    while (currentNode != null)
                    {
                        ////print the node data
                        Console.WriteLine(" -> " + currentNode.NodeData);
                        currentNode = currentNode.Next;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return list;
        }

        /// <summary>
        /// Searches the element into linked list.
        /// </summary>
        /// <param name="list">The list is an instance of the Linked List.</param>
        /// <param name="data">The data is to be searched into the Linked List.</param>
        /// <returns>True if element found into the List else False</returns>
        public bool SearchIntoLinkedList(LinkedList<T> list, T data)
        {
            //// The current node is temporary node for traversing into Linked List
            NewNode<T> currentNode = list.Head;
            while (currentNode != null)
            {
                try
                {
                    ////Compare two objects 
                    ////if found to be same then return true else false
                    if (object.Equals(currentNode.NodeData, data))
                    {
                        return true;
                    }

                    ////Traverse to next
                    currentNode = currentNode.Next;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return false;
        }
    }
}
