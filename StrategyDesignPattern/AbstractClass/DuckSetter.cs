using StrategyDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.AbstractClass
{
	public class DuckSetter
	{
		IFlyBehavior _flyer;
		IQuackBehavior _quacker;

		public virtual void SetFly(IFlyBehavior flyer)
		{
			_flyer = flyer;
		}

		public virtual void SetQuack(IQuackBehavior quacker)
		{
			_quacker = quacker;
		}

		public virtual void DoFly()
		{
			_flyer.Fly();
		}

		public virtual void DoQuack()
		{
			_quacker.Quack();
		}

		public virtual void Swim()
		{
			Console.WriteLine("Swim..");
		}
	}
}
