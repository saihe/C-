using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_6
{
    class RandomMath
    {

            Random ran = new Random();
            public int getNum()
            {
                int num = ran.Next(1, 7);
                return num;
            }
    }
}
