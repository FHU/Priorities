using CommunityToolkit.Mvvm.ComponentModel;
using System;
namespace Priorities.Models
{
	public partial class Priority : ObservableObject
	{
		public string Thing { get; set; }

        [ObservableProperty]
        private bool isBeingDragged;

        [ObservableProperty]
        private bool isBeingDraggedOver;

        public Priority(string priority)
		{
			Thing = priority;


		}
	}
}

