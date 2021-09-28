using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Lion : Feline
    {

        public Lion(string name, string diet, string location,
          double weight, int age, string colour, string species) : base(name, diet, location, weight, age, colour,species)
        {

        }

        public override void Sleep()
        {

            Console.WriteLine("Lion is Sleeping...");
        }


    }
}
