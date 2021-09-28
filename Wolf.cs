using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Wolf : Animal
    {

        public Wolf(string name, string diet, string location,
            double weight, int age, string colour) : base(name, diet, location, weight, age, colour)
        {
            
        }

        public override void Eat()
        {

            Console.WriteLine("I 10lbs of Meat");
            //Console.WriteLine("An Animal Eats");
        }

        public override void MakeNoise()
        {

            Console.WriteLine("Howl...");
        }

        public override void Hunt()
        {

            Console.WriteLine("Hunting Lamb");
        }

    }
}
