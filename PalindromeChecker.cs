// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
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
    /// Check whether string is palindrome or not
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Palindrome checker.
        /// </summary>
        public void PalindromeCheckMethod()
        {
            try
            {
                Utility<char> utilityObject = new Utility<char>();

                ////Call to the Palindrome checker
                utilityObject.PalindromeCheck();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}