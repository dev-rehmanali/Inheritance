
using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Bird : Animal
    {

        private string species;
        private double wingSpan;



        public Bird(string name, string diet, string location,
            double weight, int age, string colour, string species,
            double wingSpan) : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.wingSpan = wingSpan;

        }

        public virtual void Fly() {

            Console.WriteLine("Bird is Flying");
        }

    }
}
