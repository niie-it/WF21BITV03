using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPInheritance
{
	public class LopCha
	{
		public virtual void InLoiChao()
		{
			Console.WriteLine("Hello from Parent class");
		}
	}

	public class LopCon: LopCha
	{
		public override void InLoiChao()
		{
			Console.WriteLine("Hello from Child class");
		}
	}
}
