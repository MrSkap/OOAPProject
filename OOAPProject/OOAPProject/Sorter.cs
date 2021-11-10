using System;
using System.Collections.Generic;
using System.Text;

namespace OOAPProject
{
    public class Sorter
    {
        public List<Student> SortByAge(List<Student> students)
        {
            List<Student> list = students;
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count - 1 - i; j++)
                {
                    if (list[j].age > list[j + 1].age)
                    {
                        Swap(list, j, j + 1);
                    }
                }
            }
            return list;
        }

        public Teacher FindTeacherOfStudent(List<Teacher> teachers,Student student)
		{
            foreach(var teacher in teachers)
			{
                if (teacher.teachersStudents.Contains(student))
                    return teacher;
                else
                {
                    return null;
                }
            }
            return null;
		}
        
        static void Swap(List<Student> list, int s1, int s2)
        {
            Student sVrem = new Student();
            sVrem = list[s1];
            list[s1] = list[s2];
            list[s2] = sVrem;
        }
    }
}
