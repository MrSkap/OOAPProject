using System;
using System.Collections.Generic;
using System.Text;

namespace OOAPProject
{
	public class Student:Human
	{
		public int grade;
		public bool freeEducation;
		public int grants;

		public static Student CreateNewRandomStudent()
		{
			Student student = new Student();
			student.age = RandomData.CreateAge(16, 30);
			student.grade = RandomData.CreateGrade();
			student.grants = RandomData.CreateGrants();
			student.name = RandomData.CreateString(30);
			student.secondName = RandomData.CreateString(30);
			if (student.grants == 0) student.freeEducation = false;
			else student.freeEducation = true;
			return student;
		}

		
	}
}
