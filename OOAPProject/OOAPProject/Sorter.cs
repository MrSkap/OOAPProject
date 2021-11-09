using System;
using System.Collections.Generic;
using System.Text;

namespace OOAPProject
{
    public static class Sorter
    {
        public static List<Student> SortByAge(List<Student> students)
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

        static void Swap(List<Student> list, int s1, int s2)
        {
            Student sVrem = new Student();
            sVrem = list[s1];
            list[s1] = list[s2];
            list[s2] = sVrem;
        }
    }
}
