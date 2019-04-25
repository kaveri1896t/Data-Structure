// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputBinary.cs" company="Bridgelabz">
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
    /// Take number of nodes from user to calculate number of trees
    /// </summary>
    public class InputBinary
    {
        /// <summary>
        /// input for number of binary trees.
        /// </summary>
        public static void BinaryTree()
        {
            try
            {
                int numberOfElements = 0;
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter number Of Elements in the tree");
                    string stringElements = Console.ReadLine();

                    ////Check if input is a valid number
                    if (Utility<int>.IsNumber(stringElements) == false)
                    {
                        Console.WriteLine("Invalid Input");
                        continue;
                    }

                    ////Convert into integer
                    numberOfElements = Convert.ToInt32(stringElements);

                    ////Check for valid positive integer greater than zero
                    if (numberOfElements < 0)
                    {
                        Console.WriteLine("\nShould be greater than zero");
                        continue;
                    }

                    flag = false;
                }

                ////Call to Binary tree count function
                int countOfBinaryTree = NumberOfBinaryTrees.BinaryTreeCount(numberOfElements);
                Console.WriteLine("\nNumber Of Binary trees possible = " + countOfBinaryTree);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}