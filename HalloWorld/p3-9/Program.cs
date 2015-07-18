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
                //string s = Console.ReadLine();
                //string msg = "";
                Console.ReadLine();
                Console.WriteLine("ダイス1：" + rm.Dice1());
                Console.WriteLine("ダイス1：" + rm.Dice2());
                Console.WriteLine("ダイス1：" + rm.Dice3());
                Console.WriteLine(rm.Msg());
                Console.WriteLine("出目1：" + rm.result[1]);
                Console.WriteLine("出目2：" + rm.result[2]);
                Console.WriteLine("出目3：" + rm.result[3]);
                Console.WriteLine("出目4：" + rm.result[4]);
                Console.WriteLine("出目5：" + rm.result[5]);
                Console.WriteLine("出目6：" + rm.result[6]);
                Console.WriteLine("所持ポイント" + rm.pp);
            }
        }
    }
}
