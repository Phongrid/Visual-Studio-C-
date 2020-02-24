using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Animal
    {
        int sizeOfAnimal = 0;
        public int SizeOfAnimal { get => sizeOfAnimal; set => sizeOfAnimal = value; }

        String name;

        //Breathing
        public String breathing()
        {
            return "im ok";
        }
        //movements
        public string move()
        {
            return "Go";
        }
    }
}
