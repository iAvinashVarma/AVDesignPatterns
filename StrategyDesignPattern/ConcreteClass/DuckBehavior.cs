using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.ConcreteClass
{
	public class FlyWithWings : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("Fly with wings.");
		}
	}

	public class FlyHigh : IFlyBehavior
	{
		public void Fly()
		{
			Console.WriteLine("WHOOOOOOSH!");
		}
	}

	public class QuackLikeMallard : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("Quack!");
		}
	}

	public class QuackLikeSpaniel : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("Woof!");
		}
	}
}
