using System;
using System.Collections.Generic;
using System.Text;

namespace OOAPProject
{
	public abstract class Human
	{
		public int age = 0;
		public string name = "user";
		public string secondName = "MrUser";


		public abstract Human CreateNewRandomHuman();
	}
}
