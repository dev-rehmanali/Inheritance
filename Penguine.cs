using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Penguine : Bird
    {

        public Penguine(string name, string diet, string location,
            double weight, int age, string colour, string species,
            double wingSpan) : base(name, diet, location, weight, age, colour,species,wingSpan)
        {

        }

        public override void Fly()
        {
            Console.WriteLine("Penguine cannot Fly");
        }


    }
}
