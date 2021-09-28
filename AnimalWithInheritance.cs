using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Animal
    {

        private string name;
        private string diet;
        private string location;
        private double weight;
        private int age;
        private string colour;

        public Animal(string name,string diet,string location,double weight,int age,string colour){

            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;

        }

        public virtual void Eat() {

            Console.WriteLine("Eating...");

        }
        public virtual void Sleep() { 
        
            Console.WriteLine("Animal Sleeping...");

        }
        public virtual void MakeNoise() { 
        
            Console.WriteLine("Making Noise...");

        }

        public virtual void Hunt() {

            Console.WriteLine("Animals Hunt");
        }


    }
}
