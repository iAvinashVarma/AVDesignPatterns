using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			var playerOne = Factory.CreateInstance();
			playerOne.PlayerName = "Sachin";
			playerOne.TeamName = "India";
			playerOne.DisplayDetails();
			var playerTwo = Factory.CreateInstance();
			playerTwo.PlayerName = "Warne";
			playerTwo.TeamName = "Australia";
			playerTwo.DisplayDetails();
		}
	}
}
