using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht["やくそう"] = 50;
            ht["どくけしそう"] = 20;
            ht["せかいじゅのは"] = 1;
            ht["せいすい"] = 3;

            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key + "\t\t" + ht[key].ToString() + "個");
            }
        }
    }
}
