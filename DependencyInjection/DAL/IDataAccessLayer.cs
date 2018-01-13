using DependencyInjection.BL;

namespace DependencyInjection.DAL
{
	public interface IDataAccessLayer
	{
		void Add(Customer customer);

		void Update(Customer customer);

		void Delete(Customer customer);
	}
}