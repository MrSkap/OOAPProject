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

		public Student()
		{
			age = RandomData.CreateAge(16, 30);
			grade = RandomData.CreateGrade();
			grants = RandomData.CreateGrants();
			name = RandomData.CreateString(10);
			secondName = RandomData.CreateString(15);
			if (grants == 0) freeEducation = false;
			else freeEducation = true;
		}
		override public Human CreateNewRandomHuman()
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
