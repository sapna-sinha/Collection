using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProj
{
    public class DictionaryProj
    {
        static void Main()
        {
            Dictionary<string,object> dt = new Dictionary<string, object>();
            dt.Add("EmpId", 1010);
            dt.Add("EmpName", "Sapna");
            dt.Add("Salary", 2888);
            dt.Add("MgrId", 1002);
            dt.Add("Phone", "34567890");
            dt.Add("Email", "Sapna@gmail.com");

            foreach(string key in dt.Keys)
            {
                Console.WriteLine(key + " " + dt[key]);
            }
            Console.ReadLine();
            //In case of dictionary we get value in sequence but in hashtable we didn't get in sequence
        }
    }
}
