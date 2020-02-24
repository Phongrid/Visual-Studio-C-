using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Cat:Animal
    {
        String name;

        public string Name { get => name; set => name = value; }

        // cry for cat
        public string cry()
        {
            return "Meaoowwwww";
        }
        public String move() {
            return "Super Runn";
        }
    }
}
