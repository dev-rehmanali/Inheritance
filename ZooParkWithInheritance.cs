using System;

namespace Task5._1
{
    class ZooPark
    {
        static void Main(string[] args)
        {

            //Animal williumWolf = new Animal("Willium The Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            //Animal tonyTiger = new Animal("Tony The Tiger", "Meat", "Cat Land", 110, 6, "Orange and White");
            //Animal edgarEagle = new Animal("Edgar The Eagle", "Fish", "Bird Mania", 20, 15, "Black");

            Tiger tonyTiger = new Tiger("Tony The Tiger", "Meat", "Cat Land", 110, 6, "Orange and White","Siberian","White");
            Wolf williumWolf = new Wolf("Willium The Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar The Eagle", "Fish", "Bird Mania", 20, 15, "Black","Harpy",98.5);

            Bird bird = new Bird("Bird","Diet","Beach",40,5,"White","Species",56);
            Penguine penguine = new Penguine("penji","Fish","Venice-Beach",12,1,"Black and White","Sharpy",25);

            //tonyTiger.Eat();
            tonyTiger.MakeNoise();

            Animal baseAnimal = new Animal("Lion", "Meat", "Latvia", 160, 4, "Golden");

            baseAnimal.MakeNoise();

            tonyTiger.Eat();
            baseAnimal.Eat();
            williumWolf.Eat();

            Console.WriteLine();

            tonyTiger.Eat();
            edgarEagle.Eat();
            williumWolf.Eat();

            Console.WriteLine();

            baseAnimal.Sleep();
            tonyTiger.Sleep();
            edgarEagle.Sleep();
            williumWolf.Sleep();
            tonyTiger.Eat();

            Console.WriteLine();

            bird.Fly();
            tonyTiger.Sleep();
            edgarEagle.Fly();
            williumWolf.Sleep();
            penguine.Fly();




        }
    }
}
