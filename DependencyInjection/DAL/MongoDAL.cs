using DependencyInjection.BL;
using System;

namespace DependencyInjection.DAL
{
	public class MongoDAL : IDataAccessLayer
	{
		public void Add(Customer customer)
		{
			Console.WriteLine("{0} is added in MongoDB.", customer.Name);
		}

		public void Delete(Customer customer)
		{
			Console.WriteLine("{0} is deleted in MongoDB.", customer.Name);
		}

		public void Update(Customer customer)
		{
			Console.WriteLine("{0} is updated in MongoDB.", customer.Name);
		}
	}
}