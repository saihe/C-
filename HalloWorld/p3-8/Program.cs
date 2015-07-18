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
                string msg = "";
                if (s == "h")
                {
                    /*
                    for (var j = 0; j < rm.his.Count; j++)
                    {
                        msg += "履歴" + string.Format("{0,4}", j) + "：" + rm.his[j] + "\n";
                        msg += "\n";
                    }
                    */
                    foreach (string key in rm.sum.Keys)
                    {
                        msg += key + "：" + rm.sum[key] + "\n";
                    }
                    
                    foreach(string key in rm.perc.Keys)
                    {
                        msg += key + "：" + rm.perc[key].ToString("F2") + "%\n";
                    }
                    msg += "total:" + (rm.sum["1合計"] * 100) / rm.his.Count + "\n";
                    msg += "total:" + (rm.sum["2合計"] * 100) / rm.total + "\n";
                    msg += "total:" + (rm.sum["3合計"] * 100) / rm.total + "\n";
                    msg += "total:" + (rm.sum["4合計"] * 100) / rm.total + "\n";
                    msg += "total:" + (rm.sum["5合計"] * 100) / rm.total + "\n";
                    msg += "total:" + (rm.sum["6合計"] * 100) / rm.total + "\n";

                }
                else if (s == "")
                {
                    msg = "数字：" +  rm.getNum();
                    rm.total++;

                }
                Console.WriteLine(msg);


            }
        }
    }
}
