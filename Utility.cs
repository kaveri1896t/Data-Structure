﻿// --------------------------------------------------------------------------------------------------------------------
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
    /// <typeparam name="T">Anonymous data type</typeparam>
    public class Utility<T>
    {
        /// <summary>
        /// The queue is an instance of Queue class
        /// </summary>
        private Queue<T> queue = new Queue<T>(2);

        /// <summary>
        /// The temporary node of Linked List
        /// </summary>
        private NewNode<string> tempNode = null;

        /// <summary>
        /// Insert prime numbers into Prime Numbers Arrays 
        /// </summary>
        /// <returns>array of prime numbers</returns>
        public static int[,] InsertIntoPrimeArray(int[,] PrimeNumberArray)
        {
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, nineth = 0, tenth = 0;

            //// traverse till 1000
            for (int i = 2; i < 1000; i++)
            {
                ////check prime numbers between 0 to 100
                if (Utility<int>.Prime(i) == 0)
                {
                    if (i > 0 && i < 100)
                    {
                        PrimeNumberArray[0, first] = i;
                        first++;
                    }

                    ////check prime numbers between 101 to 200
                    else if (i > 100 && i < 200)
                    {
                        PrimeNumberArray[1, second] = i;
                        second++;
                    }

                    ////check prime numbers between 201 to 300
                    else if (i > 200 && i < 300)
                    {
                        PrimeNumberArray[2, third] = i;
                        third++;
                    }

                    ////check prime numbers between 301 to 400
                    else if (i > 300 && i < 400)
                    {
                        PrimeNumberArray[3, fourth] = i;
                        fourth++;
                    }

                    ////check prime numbers between 401 to 500
                    else if (i > 400 && i < 500)
                    {
                        PrimeNumberArray[4, fifth] = i;
                        fifth++;
                    }

                    ////check prime numbers between 501 to 600
                    else if (i > 500 && i < 600)
                    {
                        PrimeNumberArray[5, sixth] = i;
                        sixth++;
                    }

                    ////check prime numbers between 601 to 700
                    else if (i > 600 && i < 700)
                    {
                        PrimeNumberArray[6, seventh] = i;
                        seventh++;
                    }

                    ////check prime numbers between 701 to 800
                    else if (i > 700 && i < 800)
                    {
                        PrimeNumberArray[7, eighth] = i;
                        eighth++;
                    }

                    ////check prime numbers between 801 to 900
                    else if (i > 800 && i < 900)
                    {
                        PrimeNumberArray[8, nineth] = i;
                        nineth++;
                    }

                    ////check prime numbers between 901 to 1000
                    else if (i > 900 && i < 1000)
                    {
                        PrimeNumberArray[9, tenth] = i;
                        tenth++;
                    }
                }

            }

            return PrimeNumberArray;
        }

        /// <summary>
        /// Insert prime numbers into Prime Numbers Arrays 
        /// </summary>
        /// <returns>array of prime numbers</returns>
        public static string[,] InsertInto2DPrimeArray(string[,] primeAnagramArray, List<int> anagramNumberList)
        {
            string number;
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, nineth = 0, tenth = 0;
           
            //// traverse till 1000
            foreach (int i in anagramNumberList)
            {
                if (i > 0 && i < 100)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, first] = number;
                    first++;
                }

                ////check prime numbers between 101 to 200
                else if (i > 100 && i < 200)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, second] = number;
                    second++;
                }

                ////check prime numbers between 201 to 300
                else if (i > 200 && i < 300)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, third] = number;
                    third++;
                }

                ////check prime numbers between 301 to 400
                else if (i > 300 && i < 400)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, fourth] = number;
                    fourth++;
                }

                ////check prime numbers between 401 to 500
                else if (i > 400 && i < 500)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, fifth] = number;
                    fifth++;
                }

                ////check prime numbers between 501 to 600
                else if (i > 500 && i < 600)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, sixth] = number;
                    sixth++;
                }

                ////check prime numbers between 601 to 700
                else if (i > 600 && i < 700)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, seventh] = number;
                    seventh++;
                }

                ////check prime numbers between 701 to 800
                else if (i > 700 && i < 800)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, eighth] = number;
                    eighth++;
                }

                ////check prime numbers between 801 to 900
                else if (i > 800 && i < 900)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, nineth] = number;
                    nineth++;
                }

                ////check prime numbers between 901 to 1000
                else if (i > 900 && i < 1000)
                {
                    number = Convert.ToString(i);
                    primeAnagramArray[0, tenth] = number;
                    tenth++;
                }
            }

            return primeAnagramArray;
        }

        /// <summary>
        /// return true if the given year is a leap year
        /// </summary>
        /// <param name="year">year passed to check leap year</param>
        /// <returns>true if leap year</returns>
        public static bool IsLeapYear(int year)
        {
            //// if year is divisible by 4 and non centurion then leap year
            if ((year % 4 == 0) && (year % 100 != 0))
            {
                return true;
            }

            //// year is divisible by 400 then leap year
            if (year % 400 == 0)
            {
                return true;
            }

            //// not a leap year
            return false;
        }

        /// <summary>
        /// Gets the day of the week on given date.
        /// </summary>
        /// <param name="month">The month passed by user.</param>
        /// <param name="day">The day passed by user.</param>
        /// <param name="year">The year passed by user.</param>
        /// <returns>Day of week on specified date</returns>
        public static int GetDay(int month, int day, int year)
        {
            int y = year - ((14 - month) / 12);
            int x = y + (y / 4) - (y / 100) + (y / 400);
            int m = month + (12 * ((14 - month) / 12)) - 2;
            int d = day + x + (((31 * m) / 12) % 7);
            return d;
        }

        /// <summary>
        /// Prints the array.
        /// </summary>
        /// <param name="list">The list.</param>
        public void PrintArray(T[] list)
        {
            ////store from list to value one by one
            foreach (T value in list)
            {
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// Inserts the specified item at Rear position into the queue.
        /// </summary>
        /// <param name="value">The value to be inserted.</param>
        /// <returns>updated queue</returns>
        public Queue<T> InsertElementIntoQueue(T value)
        {
            ////check for queue overflow condition
            if (this.queue.Rear == this.queue.Maximum - 1)
            {
                Console.WriteLine("Queue Overflow...");
            }
            else
            {
                ////add element to queue
                this.queue.DataElement[++this.queue.Rear] = value;
            }

            return this.queue;
        }

        /// <summary>
        /// Deletes the element at Front position.
        /// </summary>
        public Queue<T> RemoveElementFromQueue()
        {
            ////Check the queue empty condition
            if (this.queue.Front == this.queue.Rear + 1)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                this.queue.Front += 1;
            }

            return this.queue;
        }

        /// <summary>
        /// Prints the queue elements.
        /// </summary>
        public void PrintQueue()
        {
            ////Queue empty condition
            if (this.queue.Front == this.queue.Rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                foreach (T i in this.queue.DataElement)
                {
                    Console.WriteLine("Item[" + (this.queue.Front + 1) + "]: " + i);
                }
            }
        }

        /// <summary>
        /// Deposite money into the bank.
        /// </summary>
        /// <param name="bank">The bank is an instance to access the members of BankCashCounter class.</param>
        /// <returns>Updated Initial cash</returns>
        public int DepositeMoney(BankCashCounter bank)
        {
            do
            {
                Console.WriteLine("\nEnter the Amount to be deposited into the Bank /nNote : Must be greater than zero : ");
                bank.Amount = Convert.ToInt32(Console.ReadLine());
            }
            while (bank.Amount < 0);
            BankCashCounter.InitialCash += bank.Amount;
            Console.WriteLine("\nAmount deposited successfully...");
            return BankCashCounter.InitialCash;
        }

        /// <summary>
        /// Withdraw the money from the bank.
        /// </summary>
        /// <param name="bank">The bank is an instance to access the members of BankCashCounter class.</param>
        public int WithdrawMoney(BankCashCounter bank)
        {
            Console.WriteLine("Available cash : {0} ", BankCashCounter.InitialCash);
            Console.WriteLine("\nEnter the Amount to be withdrawn from the Bank : ");
            bank.Amount = Convert.ToInt32(Console.ReadLine());
            if (bank.Amount < BankCashCounter.InitialCash)
            {
                BankCashCounter.InitialCash -= bank.Amount;
                Console.WriteLine("\nAmount withdrawn successfully...");
            }
            else
            {
                Console.WriteLine("\nCannot withdraw due to insufficient cash...");
            }

            return BankCashCounter.InitialCash;
        }

        /// <summary>
        /// Gets the path of Input File.
        /// </summary>
        /// <returns>Path as a string</returns>
        public string GetInputPath()
        {
            return @"C:\Users\admin\source\repos\BridgeLabz_2019\Data Structure Program\Data_Structure\Data_Structure\InputFile.txt";
        }

        /// <summary>
        /// Gets the output path.
        /// </summary>
        /// <returns>Path as a string</returns>
        public string GetOutputPath()
        {
            return @"C:\Users\admin\source\repos\BridgeLabz_2019\Data Structure Program\Data_Structure\Data_Structure\OutputFile.txt";
        }

        /// <summary>
        /// Sort the Linked List in Ascending order
        /// </summary>
        /// <param name="list">instance of Linked List</param>
        /// <returns>Sorted Linked List</returns>
        public LinkedList<string> SortLinkedList(LinkedList<string> list)
        {
            //// The current node is temporary node for traversing into Linked List
            NewNode<string> currentNode = list.Head;

            while (currentNode != null)
            {
                NewNode<string> currentNode1 = currentNode.Next;
                while (currentNode1 != null)
                {
                    if (currentNode.NodeData.CompareTo(currentNode1.NodeData) > 0)
                    {
                        this.tempNode.NodeData = currentNode.NodeData;
                        currentNode.NodeData = currentNode1.NodeData;
                        currentNode1.NodeData = this.tempNode.NodeData;
                    }
                    //// traverse till end
                    currentNode1 = currentNode1.Next;
                }

                //// traverse till end
                currentNode = currentNode.Next;
            }

            return list;
        }

        /// <summary>
        /// Method to check Palindrome string.
        /// </summary>
        public void PalindromeCheck()
        {
            //// Create instance of DequeOperation to access members of that class
            DequeOperation<Char> operation = new DequeOperation<Char>();

            ////Take string to check Palindrome string
            Console.WriteLine("\nEnter the string : ");
            string inputString = Console.ReadLine();

            ////Convert it to char array
            char[] ArrayOfChar = inputString.ToCharArray();

            ////adding each character to the rear of the deque
            foreach (char i in ArrayOfChar)
            {
                operation.AddRear(i);
            }

            int flag = 0;
            while (operation.GetSize() > 1)
            {
                ////Compare two characters removed from front and rear 
                if (operation.RemoveFront() != operation.RemoveRear())
                {
                    flag = 1;
                    break;
                }
            }

            ////If true then print string palindrome else not palindrome
            if (flag == 0)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
        }

        /// <summary>
        /// check the number is Prime or not.
        /// </summary>
        /// <param name="number">The number to be get checked for prime.</param>
        /// <returns>return prime number</returns>
        public static int Prime(int number)
        {
            int flag = 0;

            ////start from  2 because 1 is neither prime nor non-prime
            for (int i = 2; i <= number / 2; i++)
            {
                ////divide that number by each number upto that number
                if (number % i == 0)
                {
                    ////if not prime
                    flag = 1;
                }
            }

            return flag;
        }
    }
}
