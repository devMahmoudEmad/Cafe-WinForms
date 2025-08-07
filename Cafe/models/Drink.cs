using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Drink : Item
    {
        public Drink()
        {

        }
        public Drink(int id, string name, decimal price) : base(id, name, price)
        {
        }
        
    
    }
}
