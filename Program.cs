using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               char ans;
                do
                {
                    Console.Write("1.Linked List operations ");
                   /* Console.Write("2.Print From Linked List ");
                    Console.Write("3.Insert at first into Linked List ");
                    Console.Write("4.Insert at end into Linked List ");
                    Console.Write("5.Search string into Linked List ");*/
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            ReadIntoLinkedList b = new ReadIntoLinkedList();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice...");
                            break;
                    }

                    Console.WriteLine("Do you want to continue in Menu (y/n) : ");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                while (ans == 'Y' || ans == 'y');                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Thank you...");
            Console.ReadKey();
        }
    }
}
