using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Dessert : Item
    {
        public Dessert() { }
        public Dessert(int id, string name, decimal price) : base(id, name, price)
        {
        }
    }
}
