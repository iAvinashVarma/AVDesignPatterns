using DependencyInjection.BL;
using DependencyInjection.DAL;
using Unity;

/// <summary>
/// Dependency Injection is a technique which helps you to
/// inject depedent objects of a class.
/// </summary>
namespace DependencyInjection.UI
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			IUnityContainer unityContainer = new UnityContainer();
			unityContainer.RegisterType<Customer>();
			unityContainer.RegisterType<IDataAccessLayer, SQLServerDAL>();
			unityContainer.RegisterType<IDataAccessLayer, MongoDAL>();
			var customer = unityContainer.Resolve<Customer>();
			customer.Name = "Avinash";
			customer.Add();
		}
	}
}