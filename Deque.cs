// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Deque.cs" company="Bridgelabz">
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
    /// Double Ended queue
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class Deque<T>
    {
        /// <summary>
        /// The data is to be inserted or removed from queue
        /// </summary>
        public T data;

        /// <summary>
        /// The next is pointing to the front element
        /// </summary>
        public Deque<T> next;

        /// <summary>
        /// The pre pointing to the rear element
        /// </summary>
        public Deque<T> pre;

        /// <summary>
        /// Initializes a new instance of the <see cref="Deque{T}"/> class 
        ///  and assign default values to members
        /// </summary>
        public Deque()
        {
            this.next = null;
            this.pre = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deque{T}"/> class.
        /// and assign default values to members
        /// </summary>
        /// <param name="val">The value passed in Constructor.</param>
        public Deque(T val)
        {
            this.data = val;
            this.next = null;
            this.pre = null;
        }
    }
}
