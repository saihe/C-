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
        public int total;

        public List<int> his = new List<int>();

        public Dictionary<string, int> sum = new Dictionary<string, int>();
        public Dictionary<string, double> perc = new Dictionary<string, double>();
        public Dice()
        {
            his.Add(0);

            sum["1合計"] = 0;
            sum["2合計"] = 0;
            sum["3合計"] = 0;
            sum["4合計"] = 0;
            sum["5合計"] = 0;
            sum["6合計"] = 0;

            perc["1出現率"] = 0;
            perc["2出現率"] = 0;
            perc["3出現率"] = 0;
            perc["4出現率"] = 0;
            perc["5出現率"] = 0;
            perc["6出現率"] = 0;
        }

        public int getNum()
        {
            int num = ran.Next(1, 7);
            switch (num)
            {
                case 1:
                    sum["1合計"] +=1;
                    perc["1出現率"] = sum["1合計"] * 100 / total;
                    break;
                    
                case 2:
                    sum["2合計"] += 1;
                    perc["2出現率"] = sum["2合計"] * 100 / total;
                    break;
                case 3:
                    sum["3合計"] += 1;
                    perc["3出現率"] = sum["3合計"] * 100 / total;
                    break;
                case 4:
                    sum["4合計"] += 1;
                    perc["4出現率"] = sum["4合計"] * 100 / total;
                    break;
                case 5:
                    sum["5合計"] += 1;
                    perc["5出現率"] = sum["5合計"] * 100 / total;
                    break;
                case 6:
                    sum["6合計"] += 1;
                    perc["6出現率"] = sum["6合計"] * 100 / total;
                    break; 
            }

            his.Add(num);
            return num;
        }
        
        
    }
}
