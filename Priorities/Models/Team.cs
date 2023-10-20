using System;
namespace Priorities.Models
{
	public class Team
	{
		public string Name { get; set; }

		List<Player> Players { get; set; }


		public Team()
		{
		}
	}
}

