using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); //not good practice to instantiate obj in methods
            var rating = calculator.Calculate(this);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to level 1.");
            } else {
                Console.WriteLine("Promoted to level 2.");
            }
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
