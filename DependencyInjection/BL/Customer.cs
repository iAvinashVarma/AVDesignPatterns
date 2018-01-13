using DependencyInjection.DAL;

namespace DependencyInjection.BL
{
	public class Customer
	{
		IDataAccessLayer oDAL = null;

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Customer(IDataAccessLayer iDAL)
		{
			oDAL = iDAL;
		}

		public void Add()
		{
			oDAL.Add(this);
		}
	}
}