using System;
namespace Priorities.Models
{
    public class Ranking
    {

        public int Number { get; set; }

        public string Name { get; set; }

        //public string Sign { get; set; }

        public Color Color { get; set; }

        public int Points { get; set; }

        public Ranking(int num, string name, string hex, int pts)
        {
            Number = num;
            Name = name;
            //Sign = sign;
            Color = Color.FromArgb(hex);
            Points = pts;
        }

        public Ranking()
        {

        }
    }
}

