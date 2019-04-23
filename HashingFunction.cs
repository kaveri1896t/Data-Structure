using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class HashingFunction
    {
        /// <summary>
        /// Stores the Data using hashing function
        /// </summary>
        /// <param name="fileData">The data read from File.</param>
        /// <param name="numberToSearch">The number to search  into the List.</param>
        /// <param name="filePath">The file path of the input file.</param>
        /// <exception cref="Exception">Handles and throws Exception</exception>
        public static void Hashingfunction(ArrayList fileData, int numberToSearch, string filePath)
        {
            try
            {
                SortedLinkedList[] hashArray = new SortedLinkedList[11];

                foreach (int number in fileData)
                {
                    int remainder = number % 11;
                    if (hashArray[remainder] == null)
                    {
                        hashArray[remainder] = new SortedLinkedList();
                        hashArray[remainder].AddIntoSortedLinkedList(hashArray[remainder], number);
                    }
                    else
                    {
                        hashArray[remainder].AddIntoSortedLinkedList(hashArray[remainder], number);
                    }
                }

                for (int i = 0; i < hashArray.Length; i++)
                {
                    if (hashArray[i] != null)
                    {
                        if (hashArray[i].SearchIntoLinkedList(hashArray[i], numberToSearch)) ;
                        {
                            hashArray[i].RemoveAtPositionFromLinkedList(hashArray[i], numberToSearch);

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
