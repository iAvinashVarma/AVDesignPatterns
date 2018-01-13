using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityTesting
{
	public class Player : IPlayer
	{
		private string playerName;

		public string PlayerName
		{
			get { return playerName; }
			set { playerName = value; }
		}

		private string teamName;

		public string TeamName
		{
			get { return teamName; }
			set { teamName = value; }
		}

		public void DisplayDetails()
		{
			Console.WriteLine("Player Name : {0} | Player Team Name : {1}.", playerName, teamName);
		}
	}
}
