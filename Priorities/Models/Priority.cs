using System;
namespace Priorities.Models
{
	public class Priority
	{
		public string Thing { get; set; }

		public Priority(string priority)
		{
			Thing = priority;
		}
	}
}

