using StrategyDesignPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.ConcreteClass
{
	class SpanielDuck : DuckSetter
	{
		public SpanielDuck()
		{
			SetFly(new FlyHigh());
			SetQuack(new QuackLikeSpaniel());
		}
	}
}
