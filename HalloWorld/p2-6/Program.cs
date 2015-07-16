using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try {
                    string[] week = new string[7] { "日", "月", "火", "水", "木", "金", "土" };
                    Console.WriteLine("0～6の数字を入力してください。対応した曜日を表示します。");
                    string s = Console.ReadLine();
                    var input = int.Parse(s);
                    switch (input)
                    {
                        case 0:
                            Console.WriteLine(week[input]);
                            break;
                        case 1:
                            Console.WriteLine(week[input]);
                            break;
                        case 2:
                            Console.WriteLine(week[input]);
                            break;
                        case 3:
                            Console.WriteLine(week[input]);
                            break;
                        case 4:
                            Console.WriteLine(week[input]);
                            break;
                        case 5:
                            Console.WriteLine(week[input]);
                            break;
                        case 6:
                            Console.WriteLine(week[input]);
                            break;
                        default:
                            Console.WriteLine("0～6の範囲で入力してください");
                            continue;
                    }
                }
                catch
                {
                    Console.WriteLine("数字を入力してください");
                    continue;
                }
            }
        }
    }
}
