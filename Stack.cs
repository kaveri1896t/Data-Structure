// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
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
    /// Stack class containing Data, Front index, last index
    /// </summary>
    /// <typeparam name="T">Generic Data type</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// The stack size 
        /// </summary>
        internal static int StackSize;

        /// <summary>
        /// The top is the index of top element in stack
        /// </summary>
        internal static int Top;

        /// <summary>
        /// The Element is the list of element in stack
        /// </summary>
        internal T[] StackElements;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack{T}"/> class.
        /// Initialize with default values.
        /// </summary>
        /// <param name="length">The length of stack.</param>
        public Stack(int length)
        {
            StackSize = length;
            this.StackElements = new T[StackSize];
            Top = -1;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// If top is -1 then stack empty else not empty
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (Top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Pushes the specified element into the Stack.
        /// </summary>
        /// <param name="element">The element to be pushed.</param>
        public void Push(T element)
        {
            if (Top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full...");
            }
            else
            {
                this.StackElements[++Top] = element;
            }
        }

        /// <summary>
        /// Pops the element at the top position in Stack.
        /// </summary>
        /// <returns>false if empty stack</returns>
        public bool Pop()
        {
            ////Check if the stack is empty
            if (this.IsEmpty())
            {
                return false;
            }
            else
            {
                Top -= 1;
                return true;
            }
        }

        /// <summary>
        /// Peeks the top element of the stack.
        /// </summary>
        /// <returns>returns element at top in stack</returns>
        public T Peek()
        {
            return this.StackElements[Top];
        }

        /// <summary>
        /// Displays the stack elements.
        /// </summary>
        public void Display()
        {
            foreach (T i in this.StackElements)
            {
                Console.WriteLine("Element : {0}", i);
            }
        }
    }
}