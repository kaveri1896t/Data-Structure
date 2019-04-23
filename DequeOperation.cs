// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DequeOperation.cs" company="Bridgelabz">
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
    /// Method containing operations on queue
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class DequeOperation<T>
    {
        /// <summary>
        /// The front is the Front index
        /// </summary>
        public Deque<T> Front;

        /// <summary>
        /// The rear points to last index
        /// </summary>
        public Deque<T> Rear;

        /// <summary>
        /// The size is the size of the queue
        /// </summary>
        public int Size = 0;

        /// <summary>
        /// The value is the data to be stored into the queue
        /// </summary>
        public T Val;

        /// <summary>
        /// Add the element at front.
        /// </summary>
        /// <param name="element">The element to be inserted.</param>
        public void AddFront(T element)
        {
            //// check if empty queue
            if (this.Front == null)
            {
                //// add element to front
                this.Front.data = element;
                this.Rear = this.Front;
            }
            else
            {
                ////take temporary node 
                Deque<T> tempNode = null;

                ////assign data to be stored into the first node
                tempNode.data = element;

                ////Link that node to the front
                tempNode.next = this.Front;

                ////back link that node with front node
                this.Front.pre = tempNode;

                ////Newnode becames front node
                this.Front = tempNode;
            }

            this.Size++;
        }

        /// <summary>
        /// Add the element at the rear.
        /// </summary>
        /// <param name="element">The element to be added into queue.</param>
        public void AddRear(T element)
        {
            /////if no element in list
            if (this.Front == null) 
            {
                ////add at front
                Deque<T> tempNode = new Deque<T>(element);
                this.Front = tempNode;

                ////make front node as rear node
                this.Rear = this.Front;
            }
            else  
            {
                ////if element is there in list then add at rear
                Deque<T> tempNode = new Deque<T>(element);

                ////Add new node at rear
                this.Rear.next = tempNode;
                tempNode.pre = this.Rear;

                ////new node becomes rear node
                this.Rear = tempNode;
            }

            this.Size++;
        }

        /// <summary>
        /// Removes the front node.
        /// </summary>
        /// <returns>removed element</returns>
        public T RemoveFront()
        {
            ////check if empty queue
            if (this.Front == null)
            {
                Console.WriteLine("\nNo elements to delete");
            }
            else
            {
                ////store front value in Val 
                this.Val = this.Front.data;

                ////next of front becomes front 
                this.Front = this.Front.next;
            }

            ////After removing element decrement the size of queue
            this.Size--;

            ////return the removed element
            return this.Val;
        }

        /// <summary>
        /// Removes the rear element.
        /// </summary>
        /// <returns>removed element</returns>
        public T RemoveRear()
        {
            ////check for empty queue
            if (this.Front == null)
            {
                Console.WriteLine("No element to delete");
            }
            else
            {
                ////read data from rear node in val
                this.Val = this.Rear.data;

                ////rear node pointing to its previous element 
                this.Rear = this.Rear.pre;

                ////make rear's next null i.e no element is there after current rear node
                this.Rear.next = null;
            }

            this.Size--;
            return this.Val;
        }

        /// <summary>
        /// Determines whether queue is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this queue empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            ////if front is null then empty queue
            if (this.Front == null)
            {
                return true;
            }
            else
            {
                ////Non empty queue
                return false;
            }
        }

        /// <summary>
        /// Gets the number of elements in the queue.
        /// </summary>
        /// <returns>size of the queue</returns>
        public int GetSize()
        {
            return this.Size;
        }
    }
}