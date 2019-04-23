// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewNode.cs" company="Bridgelabz">
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
    /// Node which contains data and link to the Next node
    /// </summary>
    /// <typeparam name="T">Anonymous data type</typeparam>
    public class NewNode<T>
    {
        /// <summary>
        /// The node data is data element of class 
        /// </summary>
        public T NodeData;

        /// <summary>
        /// The Next is the pointer to the Next node
        /// </summary>
        public NewNode<T> Next;
    }
}
