using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[,] goods = new string[4 , 4];
            //ナビ部分
            goods[0, 0] = "商品番号　";
            goods[0, 1] = "在庫　";
            goods[0, 2] = "販売価格　";
            goods[0, 3] = "仕入れ価格";
            //商品1
            goods[1, 0] = "1";
            goods[1, 1] = "99";
            goods[1, 2] = "100";
            goods[1, 3] = "50";
            //商品2
            goods[2, 0] = "2";
            goods[2, 1] = "200";
            goods[2, 2] = "5000";
            goods[2, 3] = "3000";
            //商品3
            goods[3, 0] = "3";
            goods[3, 1] = "50";
            goods[3, 2] = "90";
            goods[3, 3] = "33";

            int i = 1;
            string msg = "";
            foreach (var item in goods)
            {
                
                msg += string.Format("{0,8}" , item) + "\t";
                if (i % 4 == 0 && i != 0)
                {
                    Console.WriteLine(msg);
                    msg = "\t";
                    if (i == 4)
                    {
                        Console.WriteLine("--------------------------------------------------------------------");
                        
                    }
                }
                i++;
            }
            */

            //先生のコード
            int[,] stocks = new int[4, 4];
            //商品1
            stocks[1, 0] = 1;
            stocks[1, 1] = 99;
            stocks[1, 2] = 100;
            stocks[1, 3] = 50;
            //商品2
            stocks[2, 0] = 2;
            stocks[2, 1] = 200;
            stocks[2, 2] = 5000;
            stocks[2, 3] = 3000;
            //商品3
            stocks[3, 0] = 9;
            stocks[3, 1] = 50;
            stocks[3, 2] = 90;
            stocks[3, 3] = 33;

            Console.WriteLine("商品番号　在庫　販売価格　仕入れ価格");
            Console.WriteLine("------------------------------------");
            for(int i = 0;i < 4; i++)
            {
                Console.WriteLine("[0,8][1,6][2,10][3,10]",
                stocks[i, 0],
                stocks[i, 1],
                stocks[i, 2],
                stocks[i, 3]
                );

            }


        }
    }
}
