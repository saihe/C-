using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book();
            book1.title = "C#入門";
            book1.publishedDate = new DateTime(2000, 12, 31);
            book1.author = "七月太郎";
            book1.Price = 1000;

            var book2 = new Book("C#入門", "七月太郎", new DateTime(), 1000);



            Magazine mag1 = new Magazine();

            mag1.title = "ベーシックマガジン";
            mag1.Price = 1000;
            mag1.month = 1;

            int taxIncludedPrice = mag1.getTaxIncludedPrice();
            string getMonth = mag1.getMonth();
            Console.WriteLine("税抜き価格" + book1.Price + " ");
            Console.WriteLine(mag1.title + mag1.getMonth());
            Console.WriteLine(taxIncludedPrice);
            Console.WriteLine(mag1.author);



        }
    }

    class Book
    {
        public string title;
        public string author;
        public DateTime publishedDate;
        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if(value >= 0)
                {
                    price = value;
                }
            }
        }


        public const double taxRatio = 0.08;

        public Book() { }
        public Book(string title,string author,DateTime publishedDate,int price)
        {
            this.title = title;
            this.author = author;
            this.publishedDate = publishedDate;
            this.price = price;
        }



        public int getTax()
        {
            return (int)(price * taxRatio);
        }
        public int getTaxIncludedPrice()
        {
            return price + getTax();
        }
    }


    class Magazine : Book
    {
        public int month;
        public string getMonth()
        {
            return month + "月号";
        }
    }
    class Novel : Book
    {
        public string series;
    }
}
