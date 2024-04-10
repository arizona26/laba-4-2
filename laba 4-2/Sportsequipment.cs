using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_2
{
    public class Sportsequipment
    { 
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Season { get; set; }

        public Sportsequipment (string name, decimal cost, string season)
        {
            Name = name;
            Cost = cost;
            Season = season;
        }
        public override string ToString()
        {
            return $"Name == {Name} && Cost == {Cost} && Season == {Season}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Sportsequipment sport)
            {
                return Name == sport.Name && Cost == sport.Cost && Season == sport.Season;
            }
            return false;
        }
    }
}
