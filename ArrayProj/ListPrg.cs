using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class ListPrg
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);

            foreach (int i in li)
            {
                Console.Write(i + " "  );
            }
            Console.WriteLine();
           
            li.Insert(3, 35);
            foreach (int i in li)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();


            li.RemoveAt(2);
            foreach (int i in li)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
