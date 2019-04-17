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
        public char Char1;

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceParenthesis"/> class.
        /// </summary>
        public BalanceParenthesis()
        {
            try
            {
                Stack stack = new Stack();
                Console.WriteLine("Enter the expression : ");
                string inputstring = Console.ReadLine();
                int leftcount = 0;
                int rightcount = 0;
                char[] chararray = inputstring.ToCharArray();
                foreach (char i in chararray)
                {
                    if (i == '(')
                    {
                        this.Stack_push(stack, i);
                    }

                    if (i == ')')
                    {
                        this.Stack_push(stack, i);
                    }
                }

                foreach (char i in stack)
                {
                    if (this.Stack_pop(stack) == '(')
                    {
                        leftcount++;
                    }

                    if (this.Stack_pop(stack) == ')')
                    {
                        rightcount++;
                    }
                }

                if (leftcount == rightcount)
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

        /// <summary>
        /// Push into stack.
        /// </summary>
        /// <param name="stack">The stack is a reference of a Stack.</param>
        /// <param name="char1">The char1 is the data that is to be pushed into the Stack.</param>
        public void Stack_push(Stack stack, char char1)
        {
            try
            {
                stack.Push(char1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Pop from stack
        /// </summary>
        /// <param name="stack">The instance of Stack.</param>
        /// <returns>popped character</returns>
        public char Stack_pop(Stack stack)
        {
            try
            {
                if (stack.Count > 0)
                {
                    Char1 = Convert.ToChar(stack.Pop());
                }
                else
                {
                    Console.WriteLine("Stack Empty...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return Convert.ToChar(Char1);
        }

        /// <summary>
        /// Prints the stack.
        /// </summary>
        /// <param name="stack">The stack is instance of Stack.</param>
        public void PrintStack(Stack stack)
        {
            try
            {
                Console.Write("Stack elements are : \n");
                foreach (object obj in stack)
                {
                    Console.WriteLine(obj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}