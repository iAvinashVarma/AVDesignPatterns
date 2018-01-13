using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityTesting
{
	public class Factory
	{
		public static IPlayer CreateInstance()
		{
			IUnityContainer unityContainer = new UnityContainer();
			unityContainer.RegisterType<IPlayer, Player>();
			IPlayer player = unityContainer.Resolve<IPlayer>();
			return player;
		}
	}
}
