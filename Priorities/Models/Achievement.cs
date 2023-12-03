using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priorities.Models
{
    public class Achievement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Unlocked { get; set; }
        public DateTime DateUnlocked { get; set; }

        public Achievement()
        {

        }
    }
}
