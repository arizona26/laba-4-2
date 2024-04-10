namespace laba_4_2
{
    public class Nutritionalsupplements: Sportsequipment
    {
        public string Type { get; set; }

        public Nutritionalsupplements (string name, decimal cost, string season, string type) : base(name, cost, season)
        {
            Type = type;
        }
        public override string ToString()
        {
            return $"Name == {Name} && Cost == {Cost} && Season == {Season} &&  Type =={Type} ";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Nutritionalsupplements supplements)
            {
                return Name == supplements.Name && Cost == supplements.Cost && Season == supplements.Season && Type == supplements.Type;
            }
            return false;
        }
    }
}
