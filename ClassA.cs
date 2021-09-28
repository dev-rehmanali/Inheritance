using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class ClassA
    {
        protected int i = 10;

        public int Sum(int j)
        {
            return i + j;
        }
        public int Product(int j)
        {
            return i * j;
        }
        public virtual double Division(int j)
        {
            return i / j;
        }

    }
}
