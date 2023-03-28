using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    public class Circle
    {
        public string name;
        public double radius;

        public double GetArea()
        {
            return radius * radius * 3.14; 
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Circle name = {this.name}");
            Console.WriteLine($"Circle radius = {this.radius}");
            Console.WriteLine($"원의 넓이 = {this.radius} ㅌ {this.radius} = {this.GetArea()}");
        }
    }

    public class Book_data
    {
        public long isbn;
        public string title;
        public string writer;
        public decimal price;

        public Book_data(long isbn, string title, string writer, decimal price)
        {
            this.isbn = isbn;
            this.title = title;
            this.writer = writer;
            this.price = price;
        }

        public decimal GetDiscount(decimal pp)
        {
            return this.price - (this.price * pp / 100);
        }

        public void PrintInfo(decimal p)
        {
            Console.WriteLine($"ISBN : {this.isbn}");
            Console.WriteLine($"제목 : {this.title}");
            Console.WriteLine($"저자 : {this.writer}");
            Console.WriteLine($"가격 : {this.price:N0}");
            Console.WriteLine($"할인가 ({p}%) : {GetDiscount(p):N0}원");
        }
    }

    class Figure
    {
        public double X;
        public double Y;
        public double Z;

        public Figure()
        {

        }

        public Figure(double r_w_t)
        {
            this.X = r_w_t;
        }
        public Figure(double r_w_t, double h_b)
        {
            this.X = r_w_t;
            this.Y = h_b;
        }
        public Figure(double r_w_t, double h_b, double h)
        {
            this.X = r_w_t;
            this.Y = h_b;
            this.Z = h;
        }

        public void PrintInfo()
        {
            Console.WriteLine("===============");
            if (this.X == 0)
            {
                Console.WriteLine("형식 오류");
            }
            else if (this.Y == 0)
            {
                Console.WriteLine("타원 도형 정보");
                Console.WriteLine($"반지름 = {this.X}");
                Console.WriteLine($"넓이 = {this.X * this.X * 3.14}");
            }
            else if (this.Z == 0)
            {
                Console.WriteLine("사각형 도형 정보");
                Console.WriteLine($"가로 = {this.X}");
                Console.WriteLine($"세로 = {this.Y}");
                Console.WriteLine($"넓이 = {this.X * this.Y}");
            }
            else
            {
                Console.WriteLine("사다리꼴 도형 정보");
                Console.WriteLine($"윗변 = {this.X}");
                Console.WriteLine($"아랫변 = {this.Y}");
                Console.WriteLine($"높이 = {this.Z}");
                Console.WriteLine($"넓이 = {(this.X + this.Y) * this.Z / 2}");
            }
        }

    }

    class MyZodiac
    {
        public static string[] zodiac_data = { "원숭이", "닭", "개", "돼지", "쥐", "소", "호랑이", "토끼", "용", "뱀", "말", "양" };

        public static string Get_Zodiac(int Birth_Year)
        {
            return zodiac_data[Birth_Year % 12];
        }
    }

    class Dinosaur
    {
        public string kind;

        public void Eat(string food)
        {
            Console.WriteLine($"Eating {food}.");
        }
        public void Sleep(string area)
        {
            Console.WriteLine($"Sleeping in {area}.");
        }
    }

    class Tyranno : Dinosaur
    {
        public string name;

        public void Hunt(string food)
        {
            Console.WriteLine($"{this.name} is hunting {food}.");
        }
    }

    class Dooly : Dinosaur
    {
        public string name;

        public void Sing()
        {
            Console.WriteLine($"{this.name} is now Singing");
        }
        public void Dance()
        {
            Console.WriteLine($"{this.name} is now Dancing.");
        }
    }

    public class Car
    {
        public int Speed;

        public virtual void UpSpeed(int speed)
        {
            this.Speed += speed;
            Console.WriteLine("Current Speed = {0}km/h", this.Speed);
        }
    }

    public class Sedan : Car
    {
        public override void UpSpeed(int speed)
        {
            this.Speed += speed;
            // Limit Speed is 150.
            if (this.Speed > 150) 
            {
                this.Speed = 150;
            }
            Console.WriteLine("Current Speed in Sedan = {0}km/h", this.Speed);
        }
    }

    public class Truck : Car
    {
        // no override.
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // quiz 01
            Circle circle = new Circle();
            circle.name = "Blue";
            circle.radius = 1.5;
            circle.PrintInfo();
            Console.WriteLine();

            // quiz 02
            Book_data bd1 = new Book_data(95823941023, "BookStore", "me", 15000);
            Book_data bd2 = new Book_data(95982348582, "BookShelfs", "you", 65000);

            bd1.PrintInfo(30);
            Console.WriteLine();
            bd2.PrintInfo(25);
            Console.WriteLine();

            // quiz 03
            Figure not_allowed = new Figure();
            Figure cir = new Figure(2.5);
            Figure rec = new Figure(3, 5);
            Figure tra = new Figure(2.5, 3.5, 6);
            not_allowed.PrintInfo();
            cir.PrintInfo();
            rec.PrintInfo();
            tra.PrintInfo();
            Console.WriteLine();

            // quiz 04
            Console.WriteLine($"{2009}년생은 {MyZodiac.Get_Zodiac(2009)}띠 입니다.");
            Console.WriteLine($"{1999}년생은 {MyZodiac.Get_Zodiac(1999)}띠 입니다.");
            Console.WriteLine($"{1981}년생은 {MyZodiac.Get_Zodiac(1981)}띠 입니다.");
            Console.WriteLine($"{1995}년생은 {MyZodiac.Get_Zodiac(1995)}띠 입니다.");
            Console.WriteLine();

            // quiz 05
            Tyranno tyranno = new Tyranno();
            tyranno.name = "Tyranosaur";
            Console.WriteLine("Tyranosaur");
            tyranno.Sleep("Cave");
            tyranno.Hunt("Fish");
            tyranno.Eat("Fish");
            Console.WriteLine();

            Console.WriteLine("Dooly");
            Dooly dooly = new Dooly();
            dooly.name = "Dooly";
            dooly.Sleep("Park");
            dooly.Eat("Chicken");
            dooly.Sing();
            dooly.Dance();
            Console.WriteLine();

            // What is Base?
            Console.WriteLine("What is base keyword?");
            Console.WriteLine("Base keyword is using Parents Class Member Field in Child Class");
            Console.WriteLine("ex) base.FieldName");
            Console.WriteLine(" this keyword : itself, base : Parents class");
            Console.WriteLine();


            // Override?
            Console.WriteLine("What is Override?");
            Console.WriteLine("Redefine Method, Field, Indexer, Event, etc in Parents Class");
            Console.WriteLine("You Need to Declare Parents Class with virtual keyword.");
            Console.WriteLine("Cannot Use with private keyword");
            Console.WriteLine("in Child Classes, You Need to use override keyword");
            Console.WriteLine();

            Console.WriteLine("Example of using override.");
            Sedan sedan = new Sedan();
            Truck truck = new Truck();

            Console.WriteLine("Sedan Upspeed 200");
            sedan.UpSpeed(200);
            Console.WriteLine("Truck Upspeed 200");
            truck.UpSpeed(200);
        }
    }
}
