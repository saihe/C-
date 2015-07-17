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

        public List<int> his = new List<int>();

        public int getNum()
        {
            int num = ran.Next(1, 7);
            his.Add(num);
            return num;
        }


    }
}
