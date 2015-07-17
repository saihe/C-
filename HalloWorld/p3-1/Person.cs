using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_1
{
    class Person
    {

        public string lastname;
        public string firstname;
        public string furisei;
        public string furimei;
        public DateTime bd;
        public DateTime publishedDate;
        public double Height { get; set; }
        public double Weight { get; set; }

        public Person() { }
        public Person(string lastname, string firstname, string furisei, string furimei, DateTime bd, double Height, double Weight)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.furisei = furisei;
            this.furimei = furimei;
            publishedDate = DateTime.Now;
            this.bd = bd;
            this.Height = Height;
            this.Weight = Weight;
        }


        /*private double height;
         public double Height
         {
             get { return height; }
             set { height = value; }
         }

         private int weight;
         public int Weight
         {
             get { return weight; }
             set { weight = value; }
         }
         */

        public int getAge()
        {
            int tyear = publishedDate.Year;
            int tmonth = publishedDate.Month;
            int tday = publishedDate.Day;
            int byear = bd.Year;
            int bmonth = bd.Month;
            int bday = bd.Day;

            int age = (tyear - byear);
            int agem = (tmonth - bmonth);
            int aged = (tday = bday);

            if (agem < 0)
            {
                return (age - 1);
            }
            else if (agem == 0 && aged < 0)
            {
                return (age - 1);
            }
            else if (agem == 0 && aged == 0)
            {
                return age;
            }
            else
            {
                return age;
            }


            //return age;
        }

        /*
        (1) 生年月日をYYYYMMDD形式の数字にします。→19790115
        (2) 年齢計算基準日(例えば今日)を同じく数字にします。→20120124
        (3)(年齢計算基準日 – 生年月日) / 10000 を計算し、小数点以下を切り捨てます。
        →(20121024 - 19790115) / 10000 = 33.0009 = 33
        */

    }

    class Student : Person
    {
        public string id;
        public int grade;
        public Dictionary<string, int> scores;

        public Student() { }

        public Student(string lastname, string firstname, string furisei, string furimei, DateTime bd, double Height, double Weight, Dictionary<string, int> scores) : base(lastname, firstname, furisei, furimei, bd, Height, Weight)
        {
            this.scores = scores;
        }


        public int getTotalScore()
        {
            int totalScore = 0;
            foreach (var score in scores.Values)
            {
                totalScore += score;
            }
            return totalScore;

        }
    }
}
