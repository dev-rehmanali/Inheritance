using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Eagle : Bird
    {

        public Eagle(string name, string diet, string location,
            double weight, int age, string colour, string species,
            double wingSpan) : base(name, diet, location, weight, age, colour,species,wingSpan)
        {

        }

        public override void Eat() {

            Console.WriteLine("I can eat 1lbs of Fish");
        }

        public override void MakeNoise() {

            Console.WriteLine("Whistle...");
        }

        public void LayEgg() {

            Console.WriteLine("Laying Eggs...");
        }

        public override void Fly() {

            Console.WriteLine("Eagle is Flying...");
        }

        public override void Hunt()
        {

            Console.WriteLine("Hunting Fish");
        }

    }
}
