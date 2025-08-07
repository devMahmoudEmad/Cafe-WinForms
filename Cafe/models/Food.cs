using Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Food : Item
    {
        public Food()
        {
           
        }
        public Food(int id, string name, decimal price, int validDays) : base(id, name, price)
        {
            ValidityPeriod = validDays;
        }

        public int ValidityPeriod { get; set; }
    }
}
