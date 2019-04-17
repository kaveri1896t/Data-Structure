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
    /// Read number of strings from file into the linked list
    /// </summary>
    public class ReadIntoLinkedList
    {
        public string text;
        Utility u = new Utility();
        LinkedList<string> list = new LinkedList<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadIntoLinkedList"/> class.
        /// </summary>
        public ReadIntoLinkedList()
        {
            try
            {
                char ans;
                do
                {
                    Console.WriteLine("1.Read From File To Linked List");
                    Console.WriteLine("2.Print From Linked List");
                    Console.WriteLine("3.Insert at first into Linked List");
                    Console.WriteLine("4.Insert at end into Linked List");
                    Console.WriteLine("5.Search string into Linked List");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            text = File.ReadAllText(@"C:\Users\admin\source\repos\BridgeLabz_2019\Data Structure Program\Data_Structure\Data_Structure\InputFile.txt");
                            string[] words = text.Split(',');
                            foreach (string str in words)
                            {
                                u.AddLastIntoLinkedList(list, str);
                            }

                            break;

                        case 2:
                            Console.Write("\nWords read from LinkedList are :\n");
                            u.PrintLinkedList(list);
                            break;

                        case 3:
                            Console.WriteLine("Enter string to add : ");
                            string input = Console.ReadLine();
                            Console.WriteLine("\nAfter Insering : ");
                            u.AddFirstIntoLinkedList(list, input);
                            u.PrintLinkedList(list);
                            break;

                        case 4:
                            Console.WriteLine("Enter string to add : ");
                            string input1 = Console.ReadLine();
                            u.AddLastIntoLinkedList(list, input1);
                            Console.WriteLine("\nAfter Insering : ");
                            u.PrintLinkedList(list);
                            break;

                        case 5:
                            Console.Write("\nEnter the word to search from LinkedList : ");
                            string instring = Console.ReadLine();
                            if (u.SearchLinkedList(list, instring) == true)
                            {
                                Console.WriteLine("String Found... Removing that string from Linked List...");
                                u.DeleteFromLinkedList(list, instring);
                            }
                            else
                            {
                                Console.WriteLine("String not Found... Adding that string into Linked List...");
                                u.InsertIntoLinkedList(list, instring);
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
