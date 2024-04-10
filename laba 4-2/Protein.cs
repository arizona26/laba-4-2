using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_2
{
    public class Protein : Nutritionalsupplements
    {
        public string Kind { get; set; }
        public Protein(string name, decimal cost, string season, string type,string kind) : base(name, cost, season, type)
        {
            this.Kind = kind;
        }
        public override string ToString()
        {
            return $"Name == {Name} && Cost == {Cost} && Season == {Season} &&  Type =={Type} && Kind = {Kind} ";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Protein protein)
            {
                return Name == protein.Name && Cost == protein.Cost && Season == protein.Season && Type == protein.Type && Kind ==protein.Kind;
            }
            return false;
        }
    }
}
