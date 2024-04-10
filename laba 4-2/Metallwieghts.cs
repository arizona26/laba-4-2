using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_2
{
    public class Metallwieghts : Bar
    {
        public string Material {  get; set; }
        public Metallwieghts(string name, decimal cost, string season, int weight,string material) : base(name, cost, season, weight)
        {
            this.Material = material;
        }
        public override string ToString()
        {
            return $"Name == {Name} && Cost == {Cost} && Season == {Season} && Weight == {Weight} && Material == {Material}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Metallwieghts metallwieghts)
            {
                return Name == metallwieghts.Name && Cost == metallwieghts.Cost && Season == metallwieghts.Season && Weight == metallwieghts.Weight && Material==metallwieghts.Material;
            }
            return false;
        }
    }
}
