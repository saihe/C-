using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    class Main
    {
        static void main(string[] args)
        {
            while (true)
            {
                Interface inter = new Interface();
                Console.WriteLine("勝負！");

                Console.WriteLine("あなたの行動");
                Console.WriteLine("敵体力：" + inter.stamina + "チャージ：" + inter.charge);
                Console.WriteLine("0：中段攻撃　1：下段攻撃　2：超必殺技　3：中断防御　4：下段防御");
                inter.battle(int.Parse(Console.ReadLine()));
            }
        }
    }
}
