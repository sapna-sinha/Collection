using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class ArrayListPrg
    {
        static void Main()
        {
            //we can also specify the initial capacity
            //ArrayList al1 = new ArrayList(10);
            //Console.WriteLine(al1.Capacity);

            //its parameterless
            ArrayList al = new ArrayList();
            
            Console.WriteLine(al.Capacity);
            al.Add(100);
            al.Add(200);
            al.Add(300);
            al.Add(400);

            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);

            foreach(object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            al.Insert(3, 350);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            //al.Remove(200);
            //foreach (object obj in al)
            //{
            //    Console.Write(obj + " ");
            //}
            //Console.WriteLine();

            al.RemoveAt(1);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
