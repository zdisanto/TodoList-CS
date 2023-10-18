using System;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		// To make the todo list:
		List<string> todoList = new List<string>();
		
		// To grab current date & time:
		DateTime date = DateTime.Now;
		
		// Todo List Header:
		Console.WriteLine("== Welcome to your Terminal Todo List ==");
       	Console.WriteLine("Today is {0:d} at {0:T} UTC.\n", date);
		
		// Todo List Functionality:
		while (true) {
			Console.WriteLine("Type a number and press ENTER to complete a function:");
			Console.WriteLine("\t1. Add Task");
			Console.WriteLine("\t2. Delete Task");
			Console.WriteLine("\t3. List Tasks");
			Console.WriteLine("\t4. Exit Program");
			// Grabbing the number the user chose (can't user userChoice...)
			int number = int.Parse(Console.ReadLine());
			
			// If user presses '1': 
			if (number == 1) {
				Console.Write("Add a task: "); 
			 	string task = Console.ReadLine(); 
				todoList.Add(task); 
			 	Console.Clear(); 
			 	Console.WriteLine("Your task was added successfully!");
				
			// If user presses '2': 
			} else if (number == 2) {
				if (todoList.Count > 0) { 
 					Console.WriteLine("Enter the number of the task you want to delete:");
					for (int i = 0; i < todoList.Count; i++) { 
						Console.WriteLine("\t[" + (i + 1) + "] " + todoList[i]); 
					}
					int taskNum = int.Parse(Console.ReadLine());
					taskNum--;

					if (taskNum >= 0 && taskNum < todoList.Count) { 
						todoList.RemoveAt(taskNum); 
 						Console.Clear(); 
 						Console.WriteLine("Your task was deleted successfully!"); 
 						Console.WriteLine("");
					} else { 
 						Console.Clear(); 
 						Console.WriteLine("404: Task Not Found."); 
 						Console.WriteLine("");
					}
				// If there are no items in the todo list:
				} else { 
					Console.WriteLine("There are no items in your Todo list."); 
					Console.WriteLine("");
				} 
			// If user presses '3': 
			} else if (number == 3) {
				// If there are no items in the todo list:
				if (todoList.Count > 0) { 
					Console.WriteLine("Your Todo List: ");
					for (int i = 0; i < todoList.Count; i++) { 
						Console.WriteLine("\t- " + todoList[i]); 
					}
				} else {
					Console.WriteLine("There are no items in your Todo list."); 
					Console.WriteLine("");
				}
				Console.WriteLine("");
				
			// If user presses '4':
			} else if (number == 4) { 
 			  break;
			// If user presses anything other than 1-4, error statement:
			} else { 
				Console.WriteLine("404: Request Not Found.\n"); 
			}
		} Console.WriteLine("Good bye!"); 
	}
}
