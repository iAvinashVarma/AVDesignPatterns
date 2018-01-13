using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl
{
	class Program
	{
		static void Main(string[] args)
		{
			var user = new User(new SQLServerDAL());
			user.Add();
		}
	}

	class User
	{
		IDataAccessLayer dataAccessLayer;

		public User(IDataAccessLayer dataAccessLayer)
		{
			this.dataAccessLayer = dataAccessLayer;
		}

		public bool IsValid
		{
			get { return true; }
		}

		public void Add()
		{
			if (IsValid)
			{
				dataAccessLayer.Add(this);
			}
		}
	}

	class MySQLDAL : IDataAccessLayer
	{
		public void Add(User user)
		{
			Console.WriteLine("Using MySQLDatabase");
		}
	}

	class SQLServerDAL : IDataAccessLayer
	{
		public void Add(User user)
		{
			Console.WriteLine("Using SQLServerDatabase.");
		}
	}

	interface IDataAccessLayer
	{
		void Add(User user);
	}
}
