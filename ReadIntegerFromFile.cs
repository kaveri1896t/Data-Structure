// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadIntegerFromFile.cs" company="Bridgelabz">
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
    /// Read Integer from file
    /// </summary>
    /// <typeparam name="T">Anonymous type</typeparam>
    public class ReadIntegerFromFile<T>
    {
        /// <summary>
        /// The Sort List is an instance of Linked List
        /// </summary>
        internal SortedLinkedList SortList = new SortedLinkedList();

        /// <summary>
        /// The text is a string
        /// </summary>
        private string text;

        /// <summary>
        /// The u is an instance of Utility class
        /// </summary>
        private Utility<int> utilityObject = new Utility<int>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadIntegerFromFile{T}"/> class.
        /// </summary>
        public void OrderedListOperation()
        {
            try
            {
                char ans;
                do
                {
                    Console.WriteLine("1.Read From File To Linked List");
                    Console.WriteLine("2.Print From Linked List");
                    Console.WriteLine("3.Insert node into Linked List");
                    Console.WriteLine("4.Remove first node from Linked List");
                    Console.WriteLine("5.Remove last node from Linked List");
                    Console.WriteLine("6.Remove specific node from Linked List");
                    Console.WriteLine("7.Search string into Linked List");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            this.text = File.ReadAllText(Utility<int>.GetIntegerInputPath());
                            string[] number = this.text.Split('\n');
                            int[] numbers = new int[number.Length];
                            for (int n = 0; n < number.Length; n++)
                            {
                                numbers[n] = int.Parse(number[n]);
                            }

                            ////Add numbers read from file into linked list
                            foreach (int value in numbers)
                            {
                                this.SortList = this.SortList.AddLastIntoLinkedList(this.SortList, value);
                            }

                            break;

                        case 2:

                            ////print the linked list
                            Console.Write("\nnumbers read from Linked List are :\n");
                            this.SortList = this.SortList.SortLinkedList(this.SortList);
                            this.SortList = this.SortList.PrintLinkedList(this.SortList);
                            break;

                        case 3:

                            ////Insert after given node
                            Console.WriteLine("Enter number to add : ");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            this.SortList = this.SortList.AddIntoSortedLinkedList(this.SortList, input1);
                            Console.WriteLine("\nAfter Insering : ");
                            this.SortList = this.SortList.PrintLinkedList(this.SortList);
                            break;

                        case 4:

                            ////Remove first element
                            this.SortList = this.SortList.RemoveFirstFromLinkedList(this.SortList);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 5:

                            ////Remove last node from linked list
                            this.SortList = this.SortList.RemoveLastFromLinkedList(this.SortList);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 6:

                            ////Remove specific node 
                            Console.Write("\nEnter the number you want to delete from LinkedList : ");
                            int data = Convert.ToInt32(Console.ReadLine());
                            this.SortList = this.SortList.RemoveAtPositionFromLinkedList(this.SortList, data);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 7:

                            ////Search into linked list
                            Console.Write("\nEnter the word to search from LinkedList : ");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            bool flag = this.SortList.SearchIntoLinkedList(this.SortList, input2);

                            ////if found then remove else add into linked list
                            if (flag == true)
                            {
                                this.SortList = this.SortList.RemoveAtPositionFromLinkedList(this.SortList, input2);
                                Console.WriteLine("\nNumber Found... Removing that number from Linked List...");
                            }
                            else
                            {
                                this.SortList = this.SortList.AddLastIntoLinkedList(this.SortList, input2);
                                Console.WriteLine("\nNumber not Found... Adding that number into Linked List...");
                            }

                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("Do you want to operate more on Linked List (y/n) : ");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                while (ans == 'Y' || ans == 'y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return;
        }
    }
}
