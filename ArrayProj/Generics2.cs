using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class Generics2<T>
    {
        //var identified at complie time while dynamic at run time
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Multiply(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Divide(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
    public class TestGenerics 
    { 
        static void Main()
        {
            Generics2<int> g2 = new Generics2<int>();
            //g2.Add<int>(10, 20);
            //g2.Sub<int>(10, 20);
            //g2.Multiply<int>(10, 20);
            //g2.Divide<int>(20, 10);
            g2.Add(10, 20);
            g2.Sub(10, 20);
            g2.Multiply(10, 20);
            g2.Divide(20, 10);
            Console.ReadLine();
        }
    }
}
