// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NumberOfBinaryTrees.cs" company="Bridgelabz">
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
    /// Number of Binary trees class 
    /// it calculates possible sub trees of given number of nodes
    /// </summary>
    public class NumberOfBinaryTrees
    {
        /// <summary>
        /// Counts the binary tree.
        /// </summary>
        /// <param name="numberOfElements">The number of elements.</param>
        /// <returns> returns the Count of Binary trees</returns>
        public static int BinaryTreeCount(int numberOfElements)
        {
            try
            {
                //// number of trees = (2n)!/(n+1)!*(n)!
                return Factorial(2 * numberOfElements) / Factorial(numberOfElements + 1) * Factorial(numberOfElements);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// returns the factorial of given Number
        /// </summary>
        /// <param name="number">takes integer number as an parameter</param>
        /// <returns>returns the factorial of given number</returns>
        public static int Factorial(int number)
        {
            try
            {
                int factorial = number;

                while (number > 1)
                {
                    factorial = factorial * (number - 1);
                    number--;
                }

                return factorial;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}