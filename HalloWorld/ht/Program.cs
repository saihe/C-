using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ht
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["Apple"] = "リンゴ";
            ht["Orange"] = "オレンジ";
            ht["Strawbarry"] = 15;
            ht[0] = "くだもの";

            foreach(var key in ht.Keys)
            {
                Console.WriteLine("{0} : {1}", key, ht[key]);
            }

        }
    }
}
