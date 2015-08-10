using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle1
{
    class Interface
    {
        public int command;
        public int enemyStamina = 20;
        public int charge = 0;

        public int battle()
        {
            switch (command)
            {
                case 1:
                    enemyStamina -= 1;
                    charge += 1;
                    break;
                case 2:
                    enemyStamina -= 1;
                    charge += 1;
                    break;
                case 3:
                    if(charge >= 3)
                    {
                        enemyStamina -= 3;
                        charge = 0;
                    }else
                    {
                        break;
                    }
                    break;
                case 4:
                    break;
            }

            if(enemyStamina == 0)
            {
                ("終了");
            }
            return command;
        }
    }
}
