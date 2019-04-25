// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;

    /// <summary>
    /// Program Menu for Multiple methods
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                char ans;
                do
                {
                    Console.WriteLine("1.Linked List Operations For String ");
                    Console.WriteLine("2.Linked List Operations For Integer ");
                    Console.WriteLine("3.Balanced Parenthesis ");
                    Console.WriteLine("4.Bank Cash Counter ");
                    Console.WriteLine("5.Calender");
                    Console.WriteLine("6.Palindrome Checker");
                    Console.WriteLine("7.Prime number 2D array");
                    Console.WriteLine("8.Prime Anagram number 2D array");
                    Console.WriteLine("9.Prime Anagram numbers using Stack");
                    Console.WriteLine("10.Prime Anagram numbers using Queue");
                    Console.WriteLine("11.Number of Binary Search Trees");

                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            ReadIntoLinkedList<string> b = new ReadIntoLinkedList<string>();
                            break;

                        case 2:
                            ReadIntegerFromFile<int> b1 = new ReadIntegerFromFile<int>();
                            b1.OrderedListOperation();
                            break;

                        case 3:
                            BalanceParenthesis b2 = new BalanceParenthesis();
                            b2.CheckBalancedParenthesis();
                            break;

                        case 4:
                            BankCashCounter bcc = new BankCashCounter();
                            bcc.BankCashCounterOperations();
                            break;

                        case 5:
                            Calendar.DisplayCalendar();
                            break;

                        case 6:
                            PalindromeChecker pc = new PalindromeChecker();
                            pc.PalindromeCheckMethod();
                            break;

                        case 7:
                            Prime2DArray.Prime2DOperation();
                            break;

                        case 8:
                            PrimeAnagram2DArray.PrimeAnagramFunction();
                            break;

                        case 9:
                            PrimeAnagramNumberUsingStack ps = new PrimeAnagramNumberUsingStack();
                            ps.PrintPrimeAnagram();
                            break;

                        case 10:
                            PrimeAnagramNumberUsingQueue pq = new PrimeAnagramNumberUsingQueue();
                            pq.PrintPrimeAnagram();
                            break;

                        case 11:
                            InputBinary.BinaryTree();
                            break;

                        default:
                            Console.WriteLine("Invalid Choice...");
                            break;
                    }

                    Console.WriteLine("\nDo you want to continue in Menu (y/n) : ");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                while (ans == 'Y' || ans == 'y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Thank you...");
        }
    }
}