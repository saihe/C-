using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_3
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
            score["西"]   = 10;
            foreach(var key in score.Keys)
            {
                Console.WriteLine("氏名：{0}\t点数：{1,3}", key, score[key]);
            }
        }
    }
}
