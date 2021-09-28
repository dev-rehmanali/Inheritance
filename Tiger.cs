using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Tiger : Feline
    {

        private string colourStripes;

        public Tiger(string name, string diet, string location,
           double weight, int age, string colour, string species,
           string colourStripes) : base(name, diet, location, weight, age, colour,species)
        {
            this.colourStripes = colourStripes;

        }

        public override void Eat()
        {

            Console.WriteLine("I can eat 20lbs of Meat");
        }

        public override void MakeNoise()
        {

            Console.WriteLine("ROAAAAAAAAR");
        }

        public override void Hunt()
        {

            Console.WriteLine("Hunting Deer");
        }


    }
}
