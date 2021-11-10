using System;
using System.Collections.Generic;
using System.Text;

namespace OOAPProject
{
	public class Teacher:Human
	{
		public string subject = "subject";
		public int salary;
		public List<Student> teachersStudents;
		int maxCountOfStudents = 30;

		public override Human CreateNewRandomHuman()
		{
			Teacher teacher = new Teacher();
			teacher.age = RandomData.CreateAge(22, 80);
			teacher.salary = RandomData.CreateSalary(20000, 150000);
			teacher.name = RandomData.CreateString(30);
			teacher.secondName = RandomData.CreateString(30);
			return teacher;
		}

		public void TakeRandomStudents(List<Student> students)
		{
			teachersStudents.Clear();
			Random rand = new Random();
			int count = rand.Next(0, maxCountOfStudents);
			for(int i = 0; i < count; i++)
			{
				Student newStudent = students[rand.Next(0, students.Count)];
				while(teachersStudents.Contains(newStudent))
					newStudent = students[rand.Next(0, students.Count)];
				teachersStudents.Add(newStudent);
			}
		}
	}
}
