using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_2
{
    public class Bar : Sportsequipment
    {
        public int Weight {  get; set; }
        public Bar(string name, decimal cost, string season, int weight) : base(name, cost, season)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Name == {Name} && Cost == {Cost} && Season == {Season} && Weight == {Weight}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Bar Bar)
            {
                return Name == Bar.Name && Cost == Bar.Cost && Season == Bar.Season && Weight == Bar.Weight;
            }
            return false;
        }
    }
}
