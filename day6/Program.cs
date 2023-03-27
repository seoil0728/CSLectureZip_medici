using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class Program
    {
        struct Trapezoid
        {
            public string Name;
            public double Height;
            public double Topbase;
            public double Bottombase;
        }
        struct Trapezoids
        {
            public string Name;
            public double Height;
            public double Topbase;
            public double Bottombase;

            public Trapezoids(string name, double height, double topbase, double bottombase)
            {
                this.Name = name;
                this.Height = height;
                this.Topbase = topbase;
                this.Bottombase = bottombase;
            }
        }

        struct Book
        {
            public long isbn;
            public string title;
            public string writer;
            public decimal price;

            public Book(long isbn, string title, string writer, decimal price)
            {
                this.isbn = isbn;
                this.title = title;
                this.writer = writer;
                this.price = price;
            }
        }

        struct Client_data
        {
            public string name;
            public int age;
            public string city;

            public Client_data(string name, int age, string city)
            {
                this.name = name;
                this.age = age;
                this.city = city;
            }
        }

        struct Triangle
        {
            public string name;
            public double width;
            public double height;

            public Triangle(string name, double width, double height)
            {
                this.name = name;
                this.width = width;
                this.height = height;
            }
            public double Get_width()
            {
                return this.width;
            }

            public double Get_height()
            {
                return this.height;
            }

            public string Get_name()
            {
                return this.name;
            }

            public double Get_area()
            {
                return this.width * this.height / 2;
            }
        }

        struct Another_Book
        {
            public long isbn;
            public string title;
            public string writer;
            public decimal price;

            public Another_Book(long isbn, string title, string writer, decimal price)
            {
                this.isbn = isbn;
                this.title = title;
                this.writer = writer;
                this.price = price;
            }

            public decimal Discount(decimal p)
            {
                return this.price - (this.price * p / 100);
            }
            public void Print_Book_Info(decimal p)
            {
                Console.WriteLine($"ISBN : {this.isbn}");
                Console.WriteLine($"제목 : {this.title}");
                Console.WriteLine($"저자 : {this.writer}");
                Console.WriteLine($"가격 : {this.price:N0}");
                Console.WriteLine($"할인가 ({p}%) : {Discount(p):N0}원");
            }
        }

        struct User
        {
            public string name;
            public long id;
            public int age;
            public string Address;

            public User(string name, long id, int age, string Address)
            {
                this.name = name;
                this.id = id;
                this.age = age;
                this.Address = Address;
            }

            public void Print_user_opened()
            {
                Console.WriteLine($"고객명 => {this.name}");
                Console.WriteLine($"id => {this.id}");
                Console.WriteLine($"나이 => {this.age}");
                Console.WriteLine($"주소 => {this.Address}");
            }

            public void Print_user_closed()
            {
                Console.Write("고객명 => ");
                for (int i = 0; i < this.name.Length; i++)
                {
                    if (i == 0 || i == this.name.Length - 1)
                    {
                        Console.Write(this.name[i]);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                Console.Write("id => ");
                string id_string = this.id.ToString();
                for (int i = 0; i < id_string.Length; i++)
                {
                    if (i == 0 || i == id_string.Length - 1)
                    {
                        Console.Write(id_string[i]);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"나이 => {this.age}");
                Console.WriteLine($"주소 => {this.Address}");
            }
        }
        static void Main(string[] args)
        {
            // quiz 01
            Trapezoid tz = new Trapezoid();
            tz.Name = "TZ01";
            tz.Height = 50;
            tz.Topbase = 120;
            tz.Bottombase = 230;
            Console.WriteLine(tz.Name);
            Console.WriteLine("높이 = {0}", tz.Height);
            Console.WriteLine("윗변 = {0}", tz.Topbase);
            Console.WriteLine("아랫변 = {0}", tz.Bottombase);
            Console.WriteLine("넓이 = {0}", (tz.Topbase + tz.Bottombase) * tz.Height / 2);
            Console.WriteLine();

            // quiz 02
            Trapezoids trapezoids = new Trapezoids("사다리꼴", 50, 120, 230);
            Console.WriteLine(trapezoids.Name);
            Console.WriteLine("높이 = {0}", trapezoids.Height);
            Console.WriteLine("윗변 = {0}", trapezoids.Topbase);
            Console.WriteLine("아랫변 = {0}", trapezoids.Bottombase);
            Console.WriteLine("넓이 = {0}", (trapezoids.Topbase + trapezoids.Bottombase) * trapezoids.Height / 2);
            Console.WriteLine();

            // quiz 03
            Book book1, book2;
            book1 = new Book(954823495, "어린왕자", "생텍쥐페리", 15000);
            book2 = new Book(959612429, "이것이 C#이다", "박상현", 35000);
            Console.WriteLine("첫 번째 책 정보");
            Console.WriteLine($"ISBN : {book1.isbn}");
            Console.WriteLine($"제목 : {book1.title}");
            Console.WriteLine($"저자 : {book1.writer}");
            Console.WriteLine($"가격 : {book1.price:N0}");
            Console.WriteLine();
            Console.WriteLine("두 번째 책 정보");
            Console.WriteLine($"ISBN : {book2.isbn}");
            Console.WriteLine($"제목 : {book2.title}");
            Console.WriteLine($"저자 : {book2.writer}");
            Console.WriteLine($"가격 : {book2.price:N0}");
            Console.WriteLine();

            // quiz 04
            Client_data c1, c2, c3;
            c1 = new Client_data("김철수", 24, "서울");
            c2 = new Client_data("최최최", 20, "부산");
            c3 = new Client_data("박박박", 30, "인천");

            Console.WriteLine($"고객명 => {c1.name}");
            Console.WriteLine($"나이 => {c1.age}");
            Console.WriteLine($"거주지 => {c1.city}");
            Console.WriteLine();
            Console.WriteLine($"고객명 => {c2.name}");
            Console.WriteLine($"나이 => {c2.age}");
            Console.WriteLine($"거주지 => {c2.city}");
            Console.WriteLine();
            Console.WriteLine($"고객명 => {c3.name}");
            Console.WriteLine($"나이 => {c3.age}");
            Console.WriteLine($"거주지 => {c3.city}");
            Console.WriteLine();

            // quiz 05
            Triangle t1 = new Triangle("Blue", 5, 5);
            Console.WriteLine($"정삼각형 이름 : {t1.Get_name()}");
            Console.WriteLine($"가로길이 : {t1.Get_width()}");
            Console.WriteLine($"세로길이 : {t1.Get_height()}");
            Console.WriteLine($"넓이 : {t1.Get_area()}");
            Console.WriteLine();

            // quiz 06
            Another_Book b1, b2;
            b1 = new Another_Book(1234851234, "여린왕자", "생(텍)쥐", 15000);
            b2 = new Another_Book(1259234892, "이건 C플렛이다", "짭제동", 35000);
            Console.WriteLine("첫 번째 책 정보");
            b1.Print_Book_Info(25);
            Console.WriteLine();
            Console.WriteLine("두 번째 책 정보");
            b2.Print_Book_Info(30);
            Console.WriteLine();

            // quiz 07
            User u1, u2;
            u1 = new User("에디슨", 1203182812, 24, "서울");
            u2 = new User("레노보", 1408523582, 30, "대만");

            u1.Print_user_opened();
            Console.WriteLine();
            u1.Print_user_closed();
            Console.WriteLine();
            u2.Print_user_opened();
            Console.WriteLine();
            u2.Print_user_closed();
        }
    }
}
