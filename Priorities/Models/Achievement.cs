using System;
namespace Priorities.Models
{
	public class Achievement
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public bool Unlocked { get; set; }
		public DateTime DateUnlocked { get; set; }

		public Achievement()
		{
		}
	}
}

