// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HashingFunction.cs" company="Bridgelabz">
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
    /// Hashing Function is to calculate hash value
    /// </summary>
    public class HashingFunction
    {
        /// <summary>
        /// To store the data on hashed index
        /// </summary>
        internal int[,] HashValue = new int[10, 10];

        /// <summary>
        /// The remender is to be calculated
        /// </summary>
        internal int Remender = new int();

        /// <summary>
        /// The value is to be returned from Search
        /// </summary>
        internal int Value;

        /// <summary>
        /// Take the input and calculate hash value.
        /// </summary>
        public int[,] HashFunction(List<int> list)
        {
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, nineth = 0, tenth = 0;
            foreach (int number in list)
            {
                if (CalculateRemender(number) == 0)
                {
                    HashValue[0, first] = number;
                    first++;
                }
                else if (CalculateRemender(number) == 1)
                {
                    HashValue[1, second] = number;
                    second++;
                }
                else if (CalculateRemender(number) == 2)
                {
                    HashValue[2, third] = number;
                    third++;
                }
                else if (CalculateRemender(number) == 3)
                {
                    HashValue[3, fourth] = number;
                    fourth++;
                }
                else if (CalculateRemender(number) == 4)
                {
                    HashValue[4, fifth] = number;
                    fifth++;
                }
                else if (CalculateRemender(number) == 5)
                {
                    HashValue[5, sixth] = number;
                    sixth++;
                }
                else if (CalculateRemender(number) == 6)
                {
                    HashValue[6, seventh] = number;
                    seventh++;
                }
                else if (CalculateRemender(number) == 7)
                {
                    HashValue[7, eighth] = number;
                    eighth++;
                }
                else if (CalculateRemender(number) == 8)
                {
                    HashValue[8, nineth] = number;
                    nineth++;
                }
                else if (CalculateRemender(number) == 9)
                {
                    HashValue[9, tenth] = number;
                    tenth++;
                }
            }

            return HashValue;
        }

        /// <summary>
        /// Calculates the remender of given number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public int CalculateRemender(int number)
        {
            while (number > 9)
            {
                this.Remender = number % 10;
                number = number / 10;
            }

            return this.Remender;
        }

        /// <summary>
        /// Searches the into hash array.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>index of the number</returns>
        public int SearchIntoHashArray(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(HashValue[i,j] == number)
                    {
                        Value = i;
                    }
                }
            }

            return Value;
        }
    }
}
