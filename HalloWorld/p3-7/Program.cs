using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice rm = new Dice();

            while (true)
            {
                //ナビ
                string s = Console.ReadLine();
                
                /*
                if (s == "h")
                {
                    for(var j = 0 ; j < rm.his.Count ; j++) {
                        Console.WriteLine("履歴" + string.Format("{0,4}" ,  j) + "：" + rm.his[j]);
                    }
                }else if (s == "")
                {
                    Console.WriteLine("数字：" + "{0}", rm.getNum());
                }
                */


                string msg = "";
                if (s == "h")
                {
                    for (var j = 0; j < rm.his.Count; j++)
                    {
                        msg += "履歴" + string.Format("{0,4}", j) + "：" + rm.his[j];
                        msg += "\n";

                    }
                }
                else if (s == "")
                {
                    msg = "数字：" +  rm.getNum();
                }
                Console.WriteLine(msg);

            }
        }
    }
}
