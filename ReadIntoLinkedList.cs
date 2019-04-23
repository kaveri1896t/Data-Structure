// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadIntoLinkedList.cs" company="Bridgelabz">
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
    /// Read from file to Linked List
    /// </summary>
    /// <typeparam name="T">Anonymous Type</typeparam>
    public class ReadIntoLinkedList<T>
    {
        /// <summary>
        /// The u is an instance of Utility class of type string
        /// </summary>
        private Utility<string> utilityObject = new Utility<string>();

        /// <summary>
        /// The list is an instance of Linked List of type string
        /// </summary>
        private LinkedList<string> list = new LinkedList<string>();

        /// <summary>
        /// The text read from file
        /// </summary>
        private string text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadIntoLinkedList{T}"/> class.
        /// </summary>
        public ReadIntoLinkedList()
        {
            try
            {
                char ans;
                bool flag;
                do
                {
                    Console.WriteLine("1.Read From File To Linked List");
                    Console.WriteLine("2.Print From Linked List");
                    Console.WriteLine("3.Add after node into Linked List");
                    Console.WriteLine("4.Remove first node From Linked List");
                    Console.WriteLine("5.Remove first node From Linked List");
                    Console.WriteLine("6.Remove Specified node From Linked List");
                    Console.WriteLine("7.Search string into Linked List");
                    Console.WriteLine("8.Sort the Linked List");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            this.text = File.ReadAllText(this.utilityObject.GetInputPath());
                            string[] words = this.text.Split(',');
                            foreach (string string1 in words)
                            {
                                this.list = this.list.AddIntoLinkedList(this.list, string1);
                            }

                            break;

                        case 2:
                            Console.Write("\nWords read from LinkedList are :\n");
                            this.list = this.list.PrintLinkedList(this.list);
                            break;

                        case 3:
                            Console.Write("\nEnter the node after which new node will be added into LinkedList : ");
                            string inputString = Console.ReadLine();
                            Console.Write("\nEnter the string you want to add into LinkedList : ");
                            this.text = Console.ReadLine();
                            this.list = this.list.AddAfterNodeIntoLinkedList(this.list, inputString, this.text);
                            Console.Write("\nNew Node added into LinkedList : ");
                            break;

                        case 4:
                            this.list = this.list.RemoveFirstFromLinkedList(this.list);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 5:
                            this.list = this.list.RemoveLastFromLinkedList(this.list);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 6:
                            Console.Write("\nEnter the string you want to delete from LinkedList : ");
                            string data = Console.ReadLine();
                            this.list = this.list.RemoveAtPositionFromLinkedList(this.list, data);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 7:
                            Console.Write("\nEnter the word to search from LinkedList : ");
                            string inputString1 = Console.ReadLine();
                            flag = this.list.SearchIntoLinkedList(this.list, inputString1);
                            if (flag == true)
                            {
                                Console.WriteLine("\nString Found... Removing that string from Linked List...");
                                this.list = this.list.RemoveAtPositionFromLinkedList(this.list, inputString1);
                            }
                            else
                            {
                                Console.WriteLine("\nString not Found... Adding that string into Linked List...");
                                this.list = this.list.AddIntoLinkedList(this.list, inputString1);
                            }

                            break;

                        case 8:
                            this.list = this.utilityObject.SortLinkedList(this.list);
                            Console.Write("\nLinkedList Sorted... ");
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("\nDo you want to operate more on Linked List (y/n) : ");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                while (ans == 'Y' || ans == 'y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}