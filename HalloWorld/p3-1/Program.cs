
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("鈴木","一郎","すずき","いちろう",new DateTime(1989,9,1),180,90);
            /*
            person.lastname = "田中";
            person.firstname = "太郎";
            person.furisei = "たなか";
            person.furimei = "たろう";
            person.bd = new DateTime(2009, 1, 1);
            person.publishedDate =  DateTime.Now;
            person.Height = 200;
            person.Weight = 90;*/



            Console.Write(person.lastname + person.firstname);
            Console.WriteLine("(" + person.furisei + person.furimei + ")");
            Console.WriteLine(person.bd.Year + "/" + person.bd.Month + "/" + person.bd.Day + "生まれ\t" + person.getAge() + "才");
            Console.WriteLine("身長：" + person.Height + "\t体重：" + person.Weight);
            
            /*
            var s1 = new Student();
            s1.lastname = "伊藤";
            s1.firstname = "四朗";
            s1.id = "1111";
            s1.grade = 1;
            s1.scores = new Dictionary<string, int>();
            s1.scores["国語"] = 100;
            s1.scores["英語"] = 50;
            Console.WriteLine(s1.lastname + s1.firstname);
            Console.WriteLine("合計点" + s1.getTotalScore());
            */
        }
    }



    class Person
    {

        public string lastname;
        public string firstname;
        public string furisei;
        public string furimei;
        public DateTime bd;
        public DateTime publishedDate;
        public double Height{get; set;}
        public double Weight { get; set; }
        public Person(string lastname,string firstname,string furisei,string furimei,DateTime bd,double Height,double Weight)
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
            } else if (agem == 0 && aged < 0)
            {
                return (age - 1);
            } else if (agem == 0 && aged == 0)
            {
                return age;
            }
            else { 
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
    /*
    class Student : Person
    {
        public string id;
        public int grade;
        public Dictionary<string, int> scores;
        
        public int getTotalScore()
        {
            int totalScore = 0;
            foreach(var score in scores.Values)
            {
                totalScore += score;
            }
            return totalScore;

        }
    }*/


}
