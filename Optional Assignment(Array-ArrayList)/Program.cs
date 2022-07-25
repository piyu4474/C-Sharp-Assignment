using System;

namespace Optional_Assignment_Array_ArrayList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("*****ARRAY DIFFERENT METHODS*****");
                ArrayDisplay arr = new ArrayDisplay();
                Array a = arr.display();

                ArrayMethod am = new ArrayMethod();
                am.sortArray(a); //To sort the array
                am.reverseArr(a); //To reverse the array
                am.equalArr(a); //To check the array are equals or not
        }   
    } 
    public class ArrayDisplay
    {
        public Array display()
        {
            int i;
            int j;
            Console.WriteLine("\n ----------FIRST ARRAY----------");
            Console.WriteLine("\nEnter size of Array:");
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
            return arr;
        }
     
    }
    public class ArrayMethod
    {
        public void sortArray(Array arr1)
        {
            Array.Sort(arr1);
            // Sorting array  
            Console.WriteLine("\n*****SORT METHOD*****");

            Console.WriteLine("\nSorted array list: \n");
            // Displaying sorted array  
           foreach(var item in arr1)
            {
                Console.WriteLine(item);
            }

        }

        public void reverseArr(Array arr2)
        {
            Array.Reverse(arr2);

            // Reverse array  
            Console.WriteLine("*****REVERSE METHOD*****");

            Console.WriteLine("\nReversed array list: \n");
            // Displaying reversed array  
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

        }

        public void equalArr(Array arr3)
        {
            Array a1 = arr3;
            //To check the two arrays are equals or not

            Console.WriteLine("*****Check The Two Array Are Equals Or Not*****");

            Console.WriteLine("\n" + a1.Equals(arr3));
        }
    }
}
