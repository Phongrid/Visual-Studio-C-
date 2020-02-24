using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Square : Shape
    {
        int side = 0;
        public int Side { get => side; set => side = value; }
        public override int Area()
        {
            return side * side;
        }
    }
}
