
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
            Person person = new Person();
            
            person.lastname = "田中";
            person.firstname = "太郎";
            person.furisei = "たなか";
            person.furimei = "たろう";
            person.bd = new DateTime(2009, 1, 1);
            person.publishedDate =  DateTime.Now;
            person.Height = 200;
            person.Weight = 90;

            Person p2 = new Person("鈴木", "一郎", "すずき", "いちろう", new DateTime(1989, 9, 1), 180, 90);



            Console.Write(person.lastname + person.firstname);
            Console.WriteLine("(" + person.furisei + person.furimei + ")");
            Console.WriteLine(person.bd.Year + "/" + person.bd.Month + "/" + person.bd.Day + "生まれ\t" + person.getAge() + "才");
            Console.WriteLine("身長：" + person.Height + "\t体重：" + person.Weight);
            
            
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


            var scd = new Dictionary<string, int>();
            scd["数学"] = 900;
            var s2 = new Student("鈴木", "一郎", "すずき", "いちろう", new DateTime(1989, 9, 1), 180, 90 , scd );
            
        }
    }

}
