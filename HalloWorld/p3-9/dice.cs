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
        public int num;

        public Dice()
        {
            //プレイヤー初期所持ポイント定義
            pp = 1000;
        }

        /*
        出目1の確率　→　10
        出目2の確率　→　10
        出目3の確率　→　10
        出目4の確率　→　23
        出目5の確率　→　23
        出目6の確率　→　24
        */




        //ダイス1を[Enter]で振り出目をresultに保存していく
        public int Dice1()
        {
            //ダイスの確率設定
            int num1 = ran.Next(1, 101);
            if(num1 >= 1 && num1 < 11)
            {
                num = 1;
            }
            else if(num1 >= 11 && num1 < 21)
            {
                num = 2;
            }
            else if (num1 >= 21 && num1 < 31)
            {
                num = 3;
            }
            else if (num1 >= 31 && num1 < 54)
            {
                num = 4;
            }
            else if (num1 >= 54 && num1 < 77)
            {
                num = 5;
            }
            else if (num1 >= 77 && num1 < 101)
            {
                num = 6;
            }
            result[num] ++;
            return num;
        }

        //ダイス2を[Enter]で振り出目をresultに保存していく
        public int Dice2()
        {
            //ダイスの確率設定
            int num1 = ran.Next(1, 101);
            if (num1 >= 1 && num1 < 11)
            {
                num = 1;
            }
            else if (num1 >= 11 && num1 < 21)
            {
                num = 2;
            }
            else if (num1 >= 21 && num1 < 31)
            {
                num = 3;
            }
            else if (num1 >= 31 && num1 < 54)
            {
                num = 4;
            }
            else if (num1 >= 54 && num1 < 77)
            {
                num = 5;
            }
            else if (num1 >= 77 && num1 < 101)
            {
                num = 6;
            }
            result[num] ++;
            return num;
        }

        //ダイス3を[Enter]で振り出目をresultに保存していく
        public int Dice3()
        {
            //ダイスの確率設定
            int num1 = ran.Next(1, 101);
            if (num1 >= 1 && num1 < 11)
            {
                num = 1;
            }
            else if (num1 >= 11 && num1 < 21)
            {
                num = 2;
            }
            else if (num1 >= 21 && num1 < 31)
            {
                num = 3;
            }
            else if (num1 >= 31 && num1 < 54)
            {
                num = 4;
            }
            else if (num1 >= 54 && num1 < 77)
            {
                num = 5;
            }
            else if (num1 >= 77 && num1 < 101)
            {
                num = 6;
            }
            result[num] ++;
            return num;
        }

        //条件定義
        public int getCondition()
        {
            if (result[4] == 1 && result[5] == 1 && result[6] == 1)
            {
                conditon = 1;
            }
            else if (result.Contains(3))
            {
                conditon = 2;
            }
            else if (result[1] == 1 && result[2] == 1 && result[3] == 1)
            {
                conditon = 3;
            }
            else
            {
                conditon = 4;
            }
            return conditon;
        }

        //条件に応じて処理する
        public string Msg()
        {
            msg = "";

            switch (getCondition())
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
            return msg;
        }


    }
}
