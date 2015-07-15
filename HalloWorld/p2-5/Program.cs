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

            string value = "不可";
            foreach (int key in score.Keys)
            {
                switch (key)
                {
                    case key >= 80:
                        value = "優";
                        break;
                    case key >= 70:
                        value = "良";
                        break;
                    case key >= 60:
                        value = "可";
                        break;
                    default
                        {

                        }
                }
                Console.WriteLine("氏名：{0}\t点数：{1}\t評価：{2}", key, string.Format("{0 , 3}", score[key]) , value) ;

            }
        }
    }
}
