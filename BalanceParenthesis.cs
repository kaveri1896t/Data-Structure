// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BalanceParenthesis.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Balanced Parenthesis in given Expression
    /// </summary>
    public class BalanceParenthesis
    {
        /// <summary>
        /// Checks the balanced parenthesis.
        /// </summary>
        public void CheckBalancedParenthesis()
        {
            try
            {
                ////Take Arithmetic expression from user with () brackets
                Console.WriteLine("Enter the expression : ");
                string inputstring = Console.ReadLine();

                ////Convert String into Array of characters
                char[] charArray = inputstring.ToCharArray();
                Stack<char> stack = new Stack<char>(charArray.Length);
                foreach (char i in charArray)
                {
                     ////If left parenthesis then push into stack.
                    if (i == '(')
                    {
                        stack.Push(i);
                    }

                    ////If right parenthesis then pop top element from stack
                    if (i == ')')
                    {
                        ////If not able to pop element due to stack empty condition then parenthesis are unbalanced 
                        if (!stack.Pop())
                        {
                            Console.WriteLine("\nUnbalanced Parenthesis");
                            break;
                        }
                    }
                }

                if (stack.IsEmpty())
                {
                    Console.WriteLine("\nBalanced Parenthesis");
                }
                else
                {
                    Console.WriteLine("\nUnbalanced Parenthesis");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}