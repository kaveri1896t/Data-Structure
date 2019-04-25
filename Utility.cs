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
    /// <typeparam name="T">Anonymous data type</typeparam>
    public class Utility<T>
    {
        /// <summary>
        /// The queue is an instance of Queue class
        /// </summary>
        private Queue<T> queue = new Queue<T>(2);

        /// <summary>
        /// this method checks numbers are Anagram or not.
        /// If anagram then adds first occurrence of the number into Anagram list
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <returns>true if anagram</returns>
        public static bool Anagram(int number1, int number2)
        {
            ////Convert number to string
            string stringNumber1 = number1.ToString();
            string stringNumber2 = number2.ToString();

            ////Convert string to char array
            char[] number1CharArray = stringNumber1.ToCharArray();
            char[] number2CharArray = stringNumber2.ToCharArray();

            ////Sort char array
            Array.Sort(number1CharArray);
            Array.Sort(number2CharArray);
            stringNumber1 = new string(number1CharArray);
            stringNumber2 = new string(number2CharArray);
            bool flag = false;
            if (stringNumber1.Length == stringNumber2.Length)
            {
                ////if count of two numbers are not equal then 
                if (stringNumber1 == stringNumber2)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        /// <summary>
        /// Insert prime numbers into Prime Numbers Arrays 
        /// </summary>
        /// <param name="primeNumberArray">2D array to store prime numbers.</param>
        /// <returns>array of prime numbers</returns>
        public static int[,] InsertIntoPrimeArray(int[,] primeNumberArray)
        {
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, nineth = 0, tenth = 0;
            try
            {
                //// traverse till 1000
                for (int i = 2; i < 1000; i++)
                {
                    ////check prime numbers between 0 to 100
                    if (Utility<int>.Prime(i) == 0)
                    {
                        if (i > 0 && i < 100)
                        {
                            primeNumberArray[0, first] = i;
                            first++;
                        }
                        else if (i > 100 && i < 200)
                        {
                            primeNumberArray[1, second] = i;
                            second++;
                        }
                        else if (i > 200 && i < 300)
                        {
                            ////check prime numbers between 201 to 300
                            primeNumberArray[2, third] = i;
                            third++;
                        }
                        else if (i > 300 && i < 400)
                        {
                            ////check prime numbers between 301 to 400
                            primeNumberArray[3, fourth] = i;
                            fourth++;
                        }
                        else if (i > 400 && i < 500)
                        {
                            ////check prime numbers between 401 to 500
                            primeNumberArray[4, fifth] = i;
                            fifth++;
                        }
                        else if (i > 500 && i < 600)
                        {
                            ////check prime numbers between 501 to 600
                            primeNumberArray[5, sixth] = i;
                            sixth++;
                        }
                        else if (i > 600 && i < 700)
                        {
                            ////check prime numbers between 601 to 700
                            primeNumberArray[6, seventh] = i;
                            seventh++;
                        }
                        else if (i > 700 && i < 800)
                        {
                            ////check prime numbers between 701 to 800
                            primeNumberArray[7, eighth] = i;
                            eighth++;
                        }
                        else if (i > 800 && i < 900)
                        {
                            ////check prime numbers between 801 to 900
                            primeNumberArray[8, nineth] = i;
                            nineth++;
                        }
                        else if (i > 900 && i < 1000)
                        {
                            ////check prime numbers between 901 to 1000
                            primeNumberArray[9, tenth] = i;
                            tenth++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return primeNumberArray;
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
            int y = year - (14 - month) / 12;
            int x = y + (y / 4) - (y / 100) + (y / 400);
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }

        /// <summary>
        /// Gets the integer input file path.
        /// </summary>
        /// <returns>Path as a string </returns>
        public static string GetIntegerInputPath()
        {
            return @"C:\Users\admin\source\repos\BridgeLabz_2019\Data Structure Program\Data_Structure\Data_Structure\InputInteger.txt";
        }
        
        /// <summary>
        /// check the number is Prime or not.
        /// </summary>
        /// <param name="number">The number to be get checked for prime.</param>
        /// <returns>return prime number</returns>
        public static int Prime(int number)
        {
            int flag = 0;
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return flag;
        }

        /// <summary>
        /// Checks the string is empty or Null.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>returns false if string is null or empty</returns>
        public static bool CheckString(string name)
        {
            try
            {
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// returns true if string contain any special Character
        /// </summary>
        /// <param name="userName">Takes the username </param>
        /// <returns>returns  if string contains any Character </returns>
        public static bool ContainsCharacter(string userName)
        {
            try
            {
                char[] userNameCharacter = userName.ToCharArray();
                //// check each character in given string wheather it is a Character.
                for (int i = 0; i < userNameCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(userNameCharacter[i]))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified input is number.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is number; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNumber(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Method to check Palindrome string.
        /// </summary>
        public void PalindromeCheck()
        {
            try
            {
                //// Create instance of DequeOperation to access members of that class
                DequeOperation<char> operation = new DequeOperation<char>();

                ////Take string to check Palindrome string
                Console.WriteLine("\nEnter the string : ");
                string inputString = Console.ReadLine();

                ////Convert it to char array
                char[] arrayOfChar = inputString.ToCharArray();

                ////adding each character to the rear of the deque
                foreach (char i in arrayOfChar)
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
            try
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this.queue;
        }

        /// <summary>
        /// Deletes the element at Front position.
        /// </summary>
        /// <returns>returns queue object</returns>
        public Queue<T> RemoveElementFromQueue()
        {
            try
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this.queue;
        }

        /// <summary>
        /// Prints the queue elements.
        /// </summary>
        public void PrintQueue()
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Deposit money into the bank.
        /// </summary>
        /// <param name="bank">The bank is an instance to access the members of BankCashCounter class.</param>
        /// <returns>Updated Initial cash</returns>
        public int DepositeMoney(BankCashCounter bank)
        {
            try
            {
                do
                {
                    Console.WriteLine("\nEnter the Amount to be deposited into the Bank /nNote : Must be greater than zero : ");
                    bank.Amount = Convert.ToInt32(Console.ReadLine());
                }
                while (bank.Amount < 0);

                ////Increment bank cash by amount deposited
                BankCashCounter.InitialCash += bank.Amount;
                Console.WriteLine("\nAmount deposited successfully...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return BankCashCounter.InitialCash;
        }

        /// <summary>
        /// Withdraw the money from the bank.
        /// </summary>
        /// <param name="bank">The bank is an instance to access the members of BankCashCounter class.</param>
        /// <returns>updated cash</returns>
        public int WithdrawMoney(BankCashCounter bank)
        {
            try
            {
                ////print cash available in bank
                Console.WriteLine("Available cash : {0} ", BankCashCounter.InitialCash);
                Console.WriteLine("\nEnter the Amount to be withdrawn from the Bank : ");
                bank.Amount = Convert.ToInt32(Console.ReadLine());

                ////check if amount entered is available in bank
                if (bank.Amount < BankCashCounter.InitialCash)
                {
                    ////Decrement bank cash by amount withdrawn
                    BankCashCounter.InitialCash -= bank.Amount;
                    Console.WriteLine("\nAmount withdrawn successfully...");
                }
                else
                {
                    Console.WriteLine("\nCannot withdraw due to insufficient cash...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
    }
}