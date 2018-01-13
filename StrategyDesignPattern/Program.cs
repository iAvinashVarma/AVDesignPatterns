using StrategyDesignPattern.AbstractClass;
using StrategyDesignPattern.ConcreteClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Mallard Duck : ");
			DuckHelper(new MallardDuck());

			Console.WriteLine("Spaniel Duck : ");
			DuckHelper(new SpanielDuck());

			Console.WriteLine("Customized Duck : ");
			var customizedDuck = new MallardDuck();
			customizedDuck.SetFly(new FlyHigh());
			DuckHelper(customizedDuck);
		}

		static void DuckHelper(DuckSetter duckSetter)
		{
			duckSetter.Swim();
			duckSetter.DoFly();
			duckSetter.DoQuack();
		}
	}
}
