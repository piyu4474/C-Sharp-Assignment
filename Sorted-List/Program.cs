using System;
using System.Collections;
using System.Collections.Generic;

namespace Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t--------------------GENERIC COLLECTION--------------------");
            // Key based generic Collection (Dictionary)
            Dictionary<int, string> fruitDict = new Dictionary<int, string>();
            fruitDict.Add(101, "Watermelon");
            fruitDict.Add(102, "Mango");
            fruitDict.Add(103, "Berries");
            fruitDict.Add(104, "Guava");
            fruitDict.Add(105, "Kiwi");

            // Displaying Dictionary value using Key
            Console.WriteLine("\n***Key based generic collection of fuitDict***\n");
            foreach (var d in fruitDict)
                Console.WriteLine("Dictionary Value: {0}", d);

            // Priority based Generic Collection (Stack)
            Stack<string> fruitStack = new Stack<string>();
            fruitStack.Push("Pomogranate");
            fruitStack.Push("Jackfruit");
            fruitStack.Push("Dragoan-fruit");
            // Display first value from Stack
            Console.WriteLine("\n\n***Priority based generic collection of fruitStack***");
            Console.WriteLine("\nGet first Fruit from Stack: {0}", fruitStack.Pop());


            // Priority based Generic Collection (Queues)
            Queue<string> fruitQueue = new Queue<string>();
            fruitQueue.Enqueue("Mango");
            fruitQueue.Enqueue("Dragoan-fruit");
            fruitQueue.Enqueue("Cherry");
            // Display first value from Queue
            Console.WriteLine("\n\n***Priority based generic collection of fruitQueue***");
            Console.WriteLine("\nGet first Fruit from Queue: {0}", fruitQueue.Dequeue());
            Console.WriteLine();

            // Creating Fruit records
            fruits fru = new fruits();
            fru.ID = 101;
            fru.Family = "Berries";
            fru.Name = "Strawberry";
            fru.Color = "Red";

            fruits fru1 = new fruits();
            fru1.ID = 102;
            fru1.Family = "Citrus";
            fru1.Name = "Orange";
            fru1.Color = "Orange";

            fruits fru2 = new fruits();
            fru2.ID = 103;
            fru2.Family = "Melons";
            fru2.Name = "Watermelon";
            fru2.Color = "Green";

            // Creating generic List with Fruit records
            List<fruits> fruit = new List<fruits>();
            fruit.Add(fru);
            fruit.Add(fru1);
            fruit.Add(fru2);

            // Displaying Fruit records from list collection
            Console.WriteLine("\n\n***Disply all fruit records in list collection***\n");
            foreach (fruits f in fruit)
            {
                Console.WriteLine("ID: " + f.ID);
                Console.WriteLine("Family: " + f.Family);
                Console.WriteLine("Name: " + f.Name);
                Console.WriteLine("Color: " + f.Color);
                Console.WriteLine();
            }

            // Creating SortedList of fruit
            SortedList fruSortedList = new SortedList();

            fruSortedList.Add("101", "Apple");
            fruSortedList.Add("102", "Banana");
            fruSortedList.Add("103", "Cherry");
            fruSortedList.Add("104", "Dragoan-Fruit");
            fruSortedList.Add("105", "Guava");
            fruSortedList.Add("106", "Grapes");
            fruSortedList.Add("107", "Pomogranate");

            // get a collection of the keys. 
            Console.WriteLine("\n***All records in Fruit Sorted List***\n");
            ICollection key = fruSortedList.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + fruSortedList[k]);
            }

            Console.WriteLine("\n***All records in Fruit Sorted List after adding new fruit***\n");

            if (fruSortedList.ContainsValue("Watermelon"))
            {
                Console.WriteLine("This Watermelon is already in the Fruit Sorted list");
            }
            else
            {
                fruSortedList.Add("008", "Watermelon");
            }

            // get a collection of the keys. 
            ICollection key1 = fruSortedList.Keys;

            foreach (string k1 in key1)
            {
                Console.WriteLine(k1 + ": " + fruSortedList[k1]);
            }
        }
        public class fruits
        {
            public int ID;
            public string Name;
            public string Family;
            public string Color;
        }

    }
}
