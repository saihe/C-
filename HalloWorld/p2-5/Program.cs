using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> score = new Dictionary<string, int>();
            score["矢吹"] = 2;
            score["丹下"] = 74;
            score["力石"] = 80;
            score["白木"] = 100;
            score["西"] = 10;

            string val = "不可";
            foreach (var key in score.Keys)
            {
                int jadge = score[key] / 10;
                    switch (jadge)
                    {
                        case 8:
                        case 9:
                        case 10:
                            val = "優";
                            break;
                        case 7:
                            val = "良";
                            break;
                        case 6:
                            val = "可";
                            break;
                        default:
                        val = "不可";

                        break;
                            {

                            }
                    }

                Console.WriteLine("氏名：{0}\t点数：{1}\t評価：{2}", key,  score[key] , val) ;
                
            }
        }
    }
}
