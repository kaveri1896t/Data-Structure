// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
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
    /// class QueueNode having data members and methods  
    /// </summary>
    /// <typeparam name="T">Generic data type</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// The data element is used to store value in Queue
        /// </summary>
        internal T[] DataElement;

        /// <summary>
        /// The front points to first element in Queue
        /// </summary>
        internal int Front;

        /// <summary>
        /// The rear points to last element in Queue
        /// </summary>
        internal int Rear;

        /// <summary>
        /// The Maximum is the capacity of the Queue
        /// </summary>
        internal int Maximum;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue{T}"/> class.
        /// Initialize front=0, rear=-1, Maximum to the size
        /// </summary>
        /// <param name="size">The size is the capacity of the queue.</param>
        public Queue(int size)
        {
            this.DataElement = new T[size];
            this.Front = 0;
            this.Rear = -1;
            this.Maximum = size;
        }
    }
}