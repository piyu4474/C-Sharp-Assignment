using System;

namespace Optional_Assignment_Array_ArrayList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("*****ARRAY DIFFERENT METHODS*****");

                int i;
                int j;
                Console.WriteLine("\n ----------FIRST ARRAY----------");
                Console.WriteLine("\nEnter size of first array:");
                j = Convert.ToInt32(Console.ReadLine());
                string[] arr = new string[j];
                for (i = 0; i < j; i++)
                {
                    Console.Write("\nEnter any string:  ");
                    //Storing value in an array
                    arr[i] = Console.ReadLine();
                }
                Console.WriteLine("\n");
                Console.WriteLine("*****DISPLAY ARRAY DATA*****\n");

                //Printing the value on console
                for (i = 0; i < j; i++)
                {
                    Console.WriteLine("   First Array String: {0}", arr[i]);
                }
                // Sorting array  
                Console.WriteLine("\n*****SORT METHOD*****");

                Array.Sort(arr);
                Console.WriteLine("\nSorted array list: \n");
                // Displaying sorted array  
                for (i = 0; i < j; i++)
                {
                    Console.WriteLine("\t" + arr[i] + "\n");
                }

                // Reverse array  
                Console.WriteLine("*****REVERSE METHOD*****");

                Array.Reverse(arr);
                Console.WriteLine("\nReversed array list: \n");
                // Displaying reversed array  
                for (i = 0; i < j; i++)
                {
                    Console.WriteLine("\t" + arr[i] + "\n");
                }

                Console.WriteLine("\n ----------SECOND ARRAY----------");
                int k, l;
                Console.WriteLine("\nEnter size of second array:");
                l = Convert.ToInt32(Console.ReadLine());
                string[] arr2 = new string[j];
                for (k = 0; k < l; k++)
                {
                    Console.Write("\nEnter any string:  ");
                    //Storing value in an array
                    arr2[k] = Console.ReadLine();
                }
                Console.WriteLine("\n");
                Console.WriteLine("*****DISPLAY ARRAY DATA*****\n");

                //Printing the value on console
                for (k = 0; k < l; k++)
                {
                    Console.WriteLine("   Second Array String:\n {0}", arr2[k]);
                }

                //To check the two arrays are equals or not

                Console.WriteLine("*****Check The Two Array Are Equals Or Not*****");

                Console.WriteLine("\n" + arr.Equals(arr2));            
        }
    }
}
