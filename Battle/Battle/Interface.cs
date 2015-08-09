using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle
{
    class Interface
    {
        public int command;
        public int stamina = 20;
        public int charge  = 0;

        public int battle(int c)
        {
            switch (c)
            {
                case 0:
                    stamina -= 1;
                    charge += 1;
                    break;
                case 1:
                    stamina -= 1;
                    charge += 1;
                    break;
                case 2:
                    if (charge >= 3)
                    {
                        stamina -= 3;
                        charge = 0;
                    }
                    else
                    {
                        break;
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
            return c;
        }
    }


    
}
