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
        /// The u is an instance of Utility class
        /// </summary>
        private Utility<int> utilityObject = new Utility<int>();

        /// <summary>
        /// The list is an instance of Linked List
        /// </summary>
        private LinkedList<int> list = new LinkedList<int>();

        /// <summary>
        /// The text is a string
        /// </summary>
        private string text;

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
                    Console.WriteLine("3.Insert after node into Linked List");
                    Console.WriteLine("4.Insert at end into Linked List");
                    Console.WriteLine("5.Remove first node from Linked List");
                    Console.WriteLine("6.Remove last node from Linked List");
                    Console.WriteLine("7.Remove specific node from Linked List");
                    Console.WriteLine("8.Search string into Linked List");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            this.text = File.ReadAllText(@"C:\Users\admin\source\repos\BridgeLabz_2019\Data Structure Program\Data_Structure\Data_Structure\InputInteger.txt");
                            string[] num = this.text.Split('\n');
                            int[] numbers = new int[num.Length];
                            for (int n = 0; n < num.Length; n++)
                            {
                                numbers[n] = int.Parse(num[n]);
                            }

                            foreach (int value in numbers)
                            {
                                this.list = this.list.AddIntoLinkedList(this.list, value);
                            }

                            break;

                        case 2:
                            Console.Write("\nnumbers read from Linked List are :\n");
                            this.list = this.list.PrintLinkedList(this.list);
                            break;

                        case 3:
                            Console.Write("\nEnter the node after which new node will be added into LinkedList : ");
                            int input = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\nEnter the number you want to add into LinkedList : ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            this.list = this.list.AddAfterNodeIntoLinkedList(this.list, input, number);
                            Console.Write("\nNew Node added into LinkedList : ");
                            break;

                        case 4:
                            Console.WriteLine("Enter number to add : ");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            this.list = this.list.AddIntoLinkedList(this.list, input1);
                            Console.WriteLine("\nAfter Insering : ");
                            this.list = this.list.PrintLinkedList(this.list);
                            break;

                        case 5:
                            this.list = this.list.RemoveFirstFromLinkedList(this.list);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 6:
                            this.list = this.list.RemoveLastFromLinkedList(this.list);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 7:
                            Console.Write("\nEnter the number you want to delete from LinkedList : ");
                            int data = Convert.ToInt32(Console.ReadLine());
                            this.list = this.list.RemoveAtPositionFromLinkedList(this.list, data);
                            Console.Write("\nNode deleted from LinkedList : ");
                            break;

                        case 8:
                            Console.Write("\nEnter the word to search from LinkedList : ");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            bool flag = this.list.SearchIntoLinkedList(this.list, input2);
                            if (flag == true)
                            {
                                Console.WriteLine("\nNumber Found... Removing that number from Linked List...");
                                this.list = this.list.RemoveAtPositionFromLinkedList(this.list, input2);
                            }
                            else
                            {
                                Console.WriteLine("\nNumber not Found... Adding that number into Linked List...");
                                this.list = this.list.AddIntoLinkedList(this.list, input2);
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
