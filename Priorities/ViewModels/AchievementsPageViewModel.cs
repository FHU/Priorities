using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Priorities.Models;

namespace Priorities.ViewModels
{
	public class AchievementsPageViewModel : ObservableObject
	{

		public ObservableCollection<Achievement> Achievements { get; set; }


		public AchievementsPageViewModel()
		{

			Achievements = new ObservableCollection<Achievement>();

			var achievement = new Achievement()
			{
				Title = "Snail's Pace",
				Description = "Finish voting within 5 secs of timer deadline.",
				Unlocked = true
            };

			Achievements.Add(achievement);

			achievement = new Achievement()
			{
				Title = "Fastest Man Alive",
				Description = "Prioritizer finishes his decision within 30 secs.",
				Unlocked = false
			};

            Achievements.Add(achievement);

        }
    }
}

