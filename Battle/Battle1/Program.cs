using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface inter = new Interface();
            while (true)
            {
                Console.WriteLine("1：中段　2：下段　3：超必殺技　4：ガード");
                Console.WriteLine("相手体力：" + inter.enemyStamina + "\tチャージ：" + inter.charge);
                inter.command = int.Parse(Console.ReadLine());
                Console.WriteLine("入力：" + inter.command);
                inter.battle();
            }
        }
    }
}
