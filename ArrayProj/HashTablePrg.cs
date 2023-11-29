using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class HashTablePrg
    {
        static void Main()
        {
            
            Hashtable ht = new Hashtable();
            //In arrayList we have Add method but It only takes one parameter
            //but in hashtable its takes 2 parameter first user-defined key then value
            ht.Add("EmpId", 1010);
            ht.Add("EmpName", "Sapna");
            ht.Add("Salary", 2888);
            ht.Add("MgrId", 1002);
            ht.Add("Phone", "34567890");
            ht.Add("Email", "Sapna@gmail.com");

            //Console.WriteLine(ht["Email"]);
            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key + " :" + ht[key]);
            }
            Console.ReadLine();
        }
    }
}
