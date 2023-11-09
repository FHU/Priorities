using Priorities.Views;
using System;
using System.Collections.ObjectModel;


namespace Priorities.Models
{
	public class Team
	{
		public string Name { get; set; }

		public List<Player> Players { get; set; }


		public Team()
		{
		}
	}
}

