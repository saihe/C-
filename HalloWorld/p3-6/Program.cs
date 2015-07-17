using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomMath rm = new RandomMath();

            while (true)
            {
                //ナビ
                Console.WriteLine("Enterを押すたびにランダムで数字を表示します。");
                Console.ReadKey();

                //インスタンスしてEnter入力をフィールドに渡す

                //ランダム数字を表示
                Console.WriteLine("数字：" + "{0}", rm.getNum());
                Console.WriteLine("終了");
            }
        }
    }
}
