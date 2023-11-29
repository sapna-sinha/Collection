using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class Generics
    {
        //Equals methods behave in differeny way when we try it with object (==)
        //public bool Compare(object a, object b) //internally boxing and unboxing is happen so performance issue
        //{
        //   // if (a == b)
        //   if(a.Equals(b))
        //        return true;
        //    return false;
        //}
        //public bool Compare(float a, float b)
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}

        public bool Compare<T>(T a, T b) //internally boxing and unboxing is happen so performance issue
        {
            // if (a == b)
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main()
        {
            Generics g = new Generics();
            bool result =  g.Compare<int>(2, 2);
            bool result1 = g.Compare<float>(2.4f, 2.6f);
            bool result2 = g.Compare<double>(12.33f, 43.54); //here trying to compare float and double its not throwing error
            Console.WriteLine(result1);
            Console.WriteLine(result);
            Console.WriteLine(result2); //its comparing so not typesafe
            Console.ReadLine();
        }

        //so to overcome all this problem Mircosoft introduced Generics
        //without using object how to make it type safe and perform without boxing and unboxing
    }
}
