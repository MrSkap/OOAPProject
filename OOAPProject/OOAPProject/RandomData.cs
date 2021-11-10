using System;
using System.Collections.Generic;
using System.Text;

namespace OOAPProject
{
	public static class RandomData
	{
		static int lettersOffset = 26;
		static int firstSmallLeter = System.Convert.ToInt32('a');
		static int lastSmallLeter = System.Convert.ToInt32('z');
		public static string CreateString(int length)
		{
			StringBuilder sb = new StringBuilder();
			
			for(int i = 0; i < length; i++)
			{
				sb.Append(System.Convert.ToChar(new Random().Next(firstSmallLeter, lastSmallLeter)));
			}
			return sb.ToString();
		}

		public static int CreateAge(int min, int max)
		{
			return new Random().Next(min, max);
		}

		public static int CreateGrants()
		{
			int have = new Random().Next(0, 1);
			if (have==0)
			{
				return 0;
			}
			else
			{
				return new Random().Next(1000, 45000);
			}
		}

		public static int CreateGrade()
		{
			return new Random().Next(0, 6);
		}


		public static int CreateSalary(int min, int max)
		{
			return new Random().Next(min, max);
		}
	}
}
