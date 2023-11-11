using System;
namespace Priorities.Views;
using Priorities.ViewModels;

	public partial class GetReadyPage : ContentPage
	{
		public GetReadyPage()
		{
			InitializeComponent();
			BindingContext = new GetReadyPageViewModel();
		}
	}


