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
                Console.ReadLine();
                Console.WriteLine("ダイス1：" + rm.Dice1());
                Console.WriteLine("ダイス2：" + rm.Dice2());
                Console.WriteLine("ダイス3：" + rm.Dice3());
                Console.WriteLine(rm.Msg());
                Console.WriteLine("所持ポイント" + rm.pp);
                
                //result初期化
                for(var i = 0;i <= 6; i++)
                {
                    rm.result[i] = 0;
                }
            }
        }
    }
}
