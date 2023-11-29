using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class ArrayPrg
    {
        static void Main(string[] args)
        {
            //declare and initialize
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            string[] str = new string[3] { "a", "b", "c" };
            string[] str1 = { "a", "b", "c", "d" };

            //If size is not known
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            string[] s = new string[] { "a", "b", "c" };

            //declare and assign later
            int[] intArr;
            intArr = new int[20];

            //take user input and display
            int[] arr1 = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }


            //Array Operations
            //Array namespace - Reverser,Sort,Find,Resize,Copy,Clear

            Array.Reverse(a);
            foreach(int j in a)
            {
                Console.WriteLine(j);
            }
            Array.Sort(a);

            //Under System.Linq -- Max,Min,Count,Sum 
            
            Console.WriteLine(a.Max());
            Console.WriteLine(a.Min());
            Console.WriteLine(a.Length);
            Console.ReadLine();
        }
    }
}
