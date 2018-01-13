using StrategyDesignPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.ConcreteClass
{
	class MallardDuck : DuckSetter
	{
		public MallardDuck()
		{
			SetFly(new FlyWithWings());
			SetQuack(new QuackLikeMallard());
		}
	}
}
