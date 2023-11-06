using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priorities.ViewModels
{
    public partial class AddPlayersPageViewModel : ObservableObject
    {
        /* name entry */
        [ObservableProperty]
        private string name;

        /* avatar image */
        [ObservableProperty]
        private string image;


        public AddPlayersPageViewModel()
        {
            PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(Name))
                {
                    string updateName = Name;
                }
                else if (e.PropertyName == nameof(Image))
                {
                    string updateImage = Image;
                }
            };
        }

    }

}
