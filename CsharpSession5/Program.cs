namespace CsharpSession5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//grades of students
			int grade1 = 85;
			int grade2 = 90;
			int grade3 = 78;
			int grade4 = 92;


			//collections ( data structures ) of variables
			// collection types: array, list, satck, queue, dictionary, set


			//single variable => holds a single value
			int grade; //decalre a variable to hold a single grade

			grade = 85; //assign a value to the variable

			grade = 69; //reassign or change the value of the variable

			Console.WriteLine(grade); //print the value of the variable


			Console.WriteLine("enter a grade: ");

			grade = int.Parse(Console.ReadLine());

			Console.WriteLine(grade); //print the value of the variable


			////////////////////////////////////////////////////////////////////////////


			// array => fixed size, same data type, index based

			// type[] arrayName = new type[size]; //syntax to declare an array

			int[] grades = new int[4]; //declare an array to hold 4 grades

			grades[0] = 85; //assign a value to the first element of the array

			grades[1] = 90; //assign a value to the second element of the array

			grades[2] = 78; //assign a value to the third element of the array

			grades[3] = 92; //assign a value to the fourth element of the array


			grades[2] = 55; //reassign or change the value of the third element of the array

			Console.WriteLine(grades[2]); //print the value of the third element of the array


			Console.WriteLine("enter a grade: ");

			grades[2] = int.Parse(Console.ReadLine());

			Console.WriteLine(grades[2]); //print the value of the third element of the array


			////////////////////////////////////////////////////////////////////////////


			//List => dynamic size, same data type, index based

			//List<type> listName = new List<type>(); //syntax to declare a list

			List<int> studentsGrades = new List<int>(); //declare a list to hold grades

			studentsGrades.Add(85); //add a value to the list

			studentsGrades.Add(90); //add a value to the list

			studentsGrades.Add(78); //add a value to the list

			studentsGrades.Add(92); //add a value to the list


			studentsGrades[2] = 55; //reassign or change the value of the third element of the list

			Console.WriteLine(studentsGrades[2]); //print the value of the third element of the list


			Console.WriteLine("enter a grade: ");

			studentsGrades.Add(int.Parse(Console.ReadLine()));


			int length = studentsGrades.Count; //get the number of elements in the list


			Console.WriteLine(studentsGrades[length - 1]); //print the value of the fifth element of the list


			studentsGrades.Remove(55); //remove the first occurrence of the value 55 from the list

			studentsGrades.RemoveAt(2); //remove the element at index 2 from the list ( delete studentGrades[2] )



			//Iterate Over Collections ( array, list )

			// for loop

			int counter;

			for (counter = 0; counter < studentsGrades.Count; counter++)
			{
				Console.WriteLine(studentsGrades[counter]);
			}


			// re initite couner ( set counter to 0 ) and iterate again

			for (counter = 0; counter < studentsGrades.Count; counter++)
			{
				Console.WriteLine("enter a grade: ");

				studentsGrades[counter] = int.Parse(Console.ReadLine());
			}


			//adding 10 grades to the list using a for loop

			for (counter = 0; counter < 10; counter++)
			{
				Console.WriteLine("enter a grade: ");

				studentsGrades.Add(int.Parse(Console.ReadLine()));
			}


			//removing any grade that is less than 50 from the list using a for loop

			for (counter = 0; counter < studentsGrades.Count; counter++)
			{
				if (studentsGrades[counter] < 50)
				{
					studentsGrades.RemoveAt(counter);

					counter--; //decrement counter to avoid skipping the next element after removal
				}
			}

			// Stack => LIFO: Last In, First Out

			Stack<string> browserhistory = new Stack<string>();

			browserhistory.Push("google.com");
			browserhistory.Push("amazon.com");
			browserhistory.Push("amazon.com/sell");

			string result = browserhistory.Peek();

			string result2 = browserhistory.Pop();

			int stackLength = browserhistory.Count;


			// Print all Stack elements

			Console.WriteLine("Browser History:");

			foreach (string url in browserhistory)
			{
				Console.WriteLine(url);
			}


			// Queue => FIFO: First In, First Out

			Queue<int> customerNumber = new Queue<int>();

			customerNumber.Enqueue(1);
			customerNumber.Enqueue(2);
			customerNumber.Enqueue(3);

			int firstCustomer = customerNumber.Peek();

			int firstCustomerRemoved = customerNumber.Dequeue();

			int queueLength = customerNumber.Count;


			// Print all Queue elements

			Console.WriteLine("Customer Numbers:");

			foreach (int number in customerNumber)
			{
				Console.WriteLine(number);
			}
		}
	}
}