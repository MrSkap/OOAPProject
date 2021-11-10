using System;
using System.Collections.Generic;
using System.Text;

namespace OOAPProject
{
	class Program
	{
		static List<Student> students = new List<Student>();
		static void Main(string[] args)
		{
			
			AddNewItemsInList(10);
			List<Student> studentsSortByAge = new Sorter().SortByAge(students);

			for (int i = 0; i < studentsSortByAge.Count; i++)
				Console.WriteLine(studentsSortByAge[i].age.ToString());
		}

		static void AddNewItemsInList(int count)
		{
			for(int i = 0; i < count; i++)
				students.Add(new Student());

		}



	}
}
