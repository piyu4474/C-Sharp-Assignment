using System;
using System.Collections;

namespace Assignment_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Create a hashtable and instance of that table Using Hashtable class

            Console.WriteLine("\t\t--------------------Hashtable Methods--------------------");
			Hashtable studentInformation = new Hashtable();

			// Adding key/value pair in the hashtable
			// Using Add() method
			studentInformation.Add("Sr.No.", 1);
			studentInformation.Add("Name", "Priyanka");
			studentInformation.Add("Email", "piyu28patil7@gmail.com");
			studentInformation.Add("City", "Kolhapur");
			studentInformation.Add("Mobile", 9373351996);


			Console.WriteLine("\n\t--KEY--\t--VALUE--\n");

			foreach (DictionaryEntry stud in studentInformation)
			{
				Console.WriteLine($"\t{stud.Key}:\t{stud.Value}");
			}

			// used Contains method
			Console.WriteLine("\n***Contains Method***\n");
			Console.WriteLine(studentInformation.Contains("Email"));
			Console.WriteLine(studentInformation.Contains(1));

			// used ContainsKey method
			Console.WriteLine("\n***ContainsKey Method***\n");
			Console.WriteLine(studentInformation.ContainsKey("Sr.No."));
			Console.WriteLine(studentInformation.ContainsKey("Email"));

			// used ContainsValue method
			Console.WriteLine("\n***ContainsValue Method***\n");
			Console.WriteLine(studentInformation.ContainsValue("Priyanka"));
			Console.WriteLine(studentInformation.ContainsValue("piyu28patil7@gmail.com"));

			// Count method
			Console.WriteLine("\nBefore removing any element the count of studentInformation hashtable: {0} ", studentInformation.Count);

			// To remove the elements from Hashtable which has key as "City"
			studentInformation.Remove("City");

			// Print the number of entries in Hashtable
			Console.WriteLine("After removing element the count of studentInformation hashtable: " + studentInformation.Count);

			studentInformation["Name"] = "Priyanka Patil";

			Console.WriteLine("\n---After updating Name values---");

			Console.WriteLine("\n\t--KEY--\t--VALUE--\n");

			foreach (DictionaryEntry stud in studentInformation)
			{
				Console.WriteLine($"\t{stud.Key}:\t{stud.Value}");
			}

			// clear all key value pairs
			Console.WriteLine("\nThe Hashtable key and Value Pairs are empty now...");
			studentInformation.Clear();
			foreach (var key in studentInformation.Keys)
			{
				Console.WriteLine("Key = {0}, Value = {1}", key, studentInformation[key]);
			}


            Console.WriteLine("\n\n\t\t--------------------STACK METHODS--------------------");
			// Creating a Stack
			Stack fruits = new Stack();

			// Inserting the elements into the Stack
			fruits.Push("Apple");
			fruits.Push("Banana");
			fruits.Push("Cherries");
			fruits.Push("Dragoan-fruit");
			fruits.Push("Guava");
			fruits.Push("Grapes");
			fruits.Push("Jackfruit");
			fruits.Push("Watermelon");
			fruits.Push("Kiwi");
			fruits.Push("Mango");

            Console.WriteLine("\n***Count Method***");
			// Displaying the count of elements
			// contained in the Stack
			Console.Write("\nTotal number of fruits in the Stack are : ");
			Console.WriteLine(fruits.Count);


			Console.WriteLine("\n***Display Method***");
			//display all fruits in element
			Console.WriteLine("All fruits in stack:");
			foreach (var f in fruits)
			{
				Console.WriteLine(f);
			}

			Console.WriteLine("\n***Pop Method***");
			Console.WriteLine("\nBefor using POP() method, total number of fruits in stack are: {0}", fruits.Count);
			fruits.Pop();

			// After Pop method
			Console.WriteLine("After using POP() method, total number of fruits in stack are: {0}", fruits.Count);

			Console.WriteLine("\n***Peek Method***");
			//peek method is used to get first element in stack.
			Console.WriteLine("\nElement at the top is : " + fruits.Peek());

			Console.WriteLine("\n***Contains Method***");
			//contains methos is used to check whether a specified element is present is Stack or not.
			Console.Write("\nGuava is present in this stack? : ");
			Console.WriteLine(fruits.Contains("Guava"));
			Console.Write("Pomogranate is present in this stack? : ");
			Console.WriteLine(fruits.Contains("Pomogranate"));

			Console.WriteLine("\n***Clone Method***");
			// Creating copy using Clone() method
			Stack cloneFruits = (Stack)fruits.Clone();
			Console.WriteLine("All Clone fruits in stack:\n");
			foreach (var f2 in cloneFruits)
			{
				Console.WriteLine(f2);
			}

			Console.WriteLine("\n\n\t\t--------------------QUEUE METHODS---------------------");

			Queue daysQueue = new Queue();
			// Inserting the elements
			// into the Queue

			daysQueue.Enqueue("Sunday");
			daysQueue.Enqueue("Monday");
			daysQueue.Enqueue("tuesday");
			daysQueue.Enqueue("wednesday");
			daysQueue.Enqueue("Thursday");
			daysQueue.Enqueue("Friday");
			daysQueue.Enqueue("Saturday");

            Console.WriteLine("\nDisplay all days in Queue:");
			foreach (var days in daysQueue)
			{
				Console.WriteLine(days);
			}

			//count method 
            Console.WriteLine("\n***Count Method***");
            Console.Write("\nTotal days in Queue: ");
			Console.WriteLine(daysQueue.Count);

            // Retrieveing top day of queue
            Console.WriteLine("\n***Dqueue Method***");
			Console.Write("\nTop element of queue is: ");
			Console.WriteLine(daysQueue.Dequeue());

			Console.Write("After applying Dqueue method then count of queue is: ");
			Console.WriteLine(daysQueue.Count);

			//Peek method is used to retriving first element
            Console.WriteLine("\n***Peek Method***");
			Console.WriteLine("\nElement at the beginning is : "+ daysQueue.Peek());

            //Contains method is check the elemnts is present or not in the queue
            Console.WriteLine("\n***Contains Method***");
            Console.Write("\nHoliday is present in this queue? : ");
			Console.WriteLine(daysQueue.Contains("Holiday"));

			//clear method is used to Removing all elements from Queue
			Console.WriteLine("\n***Clear method***");
			daysQueue.Clear();
			Console.Write("\nAfter applying Clear() the total days in Queue : ");
			Console.WriteLine(daysQueue.Count);

		}
	}
}
