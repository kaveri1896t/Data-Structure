// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankCashCounter.cs" company="Bridgelabz">
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
    /// Bank Cash Counter 
    /// </summary>
    public class BankCashCounter
    {
        /// <summary>
        /// The cash is the initial Amount the Bank have.
        /// </summary>
        public static int InitialCash = 50000;

        /// <summary>
        /// The Amount to be taken by user for doing transaction
        /// </summary>
        internal int Amount = 0;

        /// <summary>
        /// The u is an instance of Utility class
        /// </summary>
        private Utility<int> utilityObject = new Utility<int>();

        /// <summary>
        /// The queue1 is an instance of Queue class 
        /// created to access members of Queue class
        /// </summary>
        private Queue<int> queue1 = new Queue<int>(2);

        /// <summary>
        /// Initializes a new instance of the <see cref="BankCashCounter{T}"/> class.
        /// </summary>
        public void BankCashCounterOperations()
        {
            try
            {
                int choice;
                char ans;

                //// Insert into queue
                for (int i = 1; i <= 2; i++)
                {
                    this.utilityObject.InsertElementIntoQueue(i);
                }

                ////Remove from queue if done with transactions
                foreach (int i in this.queue1.DataElement)
                {
                    Console.WriteLine("Visiter : ");
                    do
                    {
                        BankCashCounter bank = new BankCashCounter();
                        Console.WriteLine("Which operation do you want to perform : ");
                        Console.WriteLine("1.Deposit\t2.Withdrawal : ");
                        choice = Convert.ToInt32(Console.ReadLine());

                        ////Choose the type of transaction
                        switch (choice)
                        {
                            case 1:
                                //// Deposite money into the Bank
                                Console.WriteLine("\nRemaining Bank Amount is {0} ...\n", this.utilityObject.DepositeMoney(bank));
                                break;

                            case 2:
                                ////Withdraw money from Bank
                                Console.WriteLine("\nRemaining Bank Amount is {0} ...\n", this.utilityObject.WithdrawMoney(bank));
                                break;

                            default:
                                Console.WriteLine("\nWrong Choice...");
                                break;
                        }

                        Console.WriteLine("\nDo you want to perform more transactions (y/n) : ");
                        ans = Convert.ToChar(Console.ReadLine());
                    }
                    while (ans == 'y' || ans == 'Y');
                    this.utilityObject.RemoveElementFromQueue();
                }

                Console.WriteLine("\nQueue Ended..... ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
