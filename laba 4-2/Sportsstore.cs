using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_2
{
    namespace laba_4_2
    {
        public class Sportsstore
        {
            private List<Sportsequipment> products = new List<Sportsequipment>();

            public void AddProduct(Sportsequipment product)
            {
                products.Add(product);
            }

            public List<Sportsequipment> SortByTypeAndCost()
            {
                return products.OrderBy(e => e.GetType().Name).ThenBy(e => e.Cost).ToList();
            }
            public List<Nutritionalsupplements> FindFoodAdditivesInRange(decimal min, decimal max)
            {
                return products.OfType<Nutritionalsupplements>().Where(additive => additive.Cost >= min && additive.Cost <= max).ToList();
            }
        }

    }
}
