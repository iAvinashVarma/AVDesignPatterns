using DependencyInjection.BL;
using System;

namespace DependencyInjection.DAL
{
	internal class SQLServerDAL : IDataAccessLayer
	{
		public void Add(Customer customer)
		{
			Console.WriteLine("{0} is inserted in SQL Server.", customer.Name);
		}

		public void Delete(Customer customer)
		{
			Console.WriteLine("{0} is deleted in SQL Server.", customer.Name);
		}

		public void Update(Customer customer)
		{
			Console.WriteLine("{0} is updated in SQL Server.", customer.Name);
		}
	}
}