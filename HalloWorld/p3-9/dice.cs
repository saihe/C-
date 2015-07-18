using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_7
{
    class Dice
    {
        Random ran = new Random();

        public int pp;
        public string msg;
        public int[] result = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        public int conditon;

        public Dice()
        {
            //プレイヤー初期所持ポイント定義
            pp = 1000;
            
            //条件定義
            if (result[4] == 1 && result[5] == 1 && result[6] == 1)
            {
                conditon = 1;
            }
            else if (result.Contains(3))
            {
                conditon = 2;
            }else if (result[1] == 1 && result[2] == 1 && result[3] == 1)
            {
                conditon = 3;
            }
            else
            {
                conditon = 4;
            }
        }

        //ダイス1を[Enter]で振り出目をresultに保存していく
        public int Dice1()
        {
            int num = ran.Next(1, 7);
            result[num] ++;
            return num;
        }

        //ダイス2を[Enter]で振り出目をresultに保存していく
        public int Dice2()
        {
            int num = ran.Next(1, 7);
            result[num] ++;
            return num;
        }

        //ダイス3を[Enter]で振り出目をresultに保存していく
        public int Dice3()
        {
            int num = ran.Next(1, 7);
            result[num] ++;
            return num;
        }

        //条件に応じて処理する
        public string Msg()
        {
            msg = "";
            switch (conditon)
            {
                case 1:
                msg = "プレイヤーの圧勝です+250pp";
                pp += 250;
                    break;
                case 2:
                msg = "プレイヤーの勝利です+150pp";
                pp += 150;
                    break;
                case 3:
                    msg = "プレイヤーの大敗です-150pp";
                    pp -= 150;
                    break;
                case 4:
                    msg = "プレイヤーの敗北です-50pp";
                    pp -= 50;
                    break;

            }

            //result初期化
            /*result[1] = 0;
            result[2] = 0;
            result[3] = 0;
            result[4] = 0;
            result[5] = 0;
            result[6] = 0;*/
            return msg;
        }
    }
}
