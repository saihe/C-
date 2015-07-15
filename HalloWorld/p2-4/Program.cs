using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_4
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
            score["西　"] = 10;

            int sum = 0;
            int ave = 0;
            foreach (var key in score.Keys)
            {
                Console.WriteLine("氏名：{0}　点数：{1}", key, string.Format("{0 , 3}" ,  score[key]));
                sum += score[key];
            }
            var count = score.Count;
            ave = sum / count;
            Console.WriteLine("受験者\t" + string.Format("{0,3}" , count)  + "名");
            Console.WriteLine("合計点\t" + string.Format("{0,3}", sum) + "点");
            Console.WriteLine("平均点\t" + string.Format("{0,3}", ave) + "点");
        }
    }
}
