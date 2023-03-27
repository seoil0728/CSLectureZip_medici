using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    internal class Program
    {
        static void PrintNumber()
        {
            int count_three = 0;
            for (int i = 1; i < 20; i++)
            {
                Console.Write("{0, 5}", i * 5);
                count_three++;
                if (count_three == 3)
                {
                    Console.WriteLine();
                    count_three = 0;
                }
            }
            Console.WriteLine();
        }

        static void GuguShow()
        {
            int full_gugu_start = 2, full_gugu_count = 1;
            while (full_gugu_start < 10)
            {
                full_gugu_count = 1;
                Console.WriteLine($"{full_gugu_start}단");
                while (full_gugu_count < 10)
                {
                    Console.WriteLine($"{full_gugu_start} X {full_gugu_count} = {full_gugu_start * full_gugu_count}");
                    full_gugu_count++;
                }
                full_gugu_start++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Fridge()
        {
            string stocks = "";
            string stock;
            while (true)
            {
                Console.WriteLine("Q나 q를 입력하면 종료됩니다.");
                Console.Write("우리집 냉장고에 있는 것은 >> ");
                stock = Console.ReadLine();
                if (stock == "Q" || stock == "q")
                {
                    break;
                }
                else
                {
                    stock += " ";
                    stocks += stock;
                }

            }
            Console.WriteLine("입력이 종료되었습니다.");
            if (stocks == "")
            {
                Console.WriteLine("냉장고가 비어있어요.. 오늘은 굶어야해요");
            }
            else
            {
                Console.WriteLine($"냉장고에 들은 것은 : {stocks}");
            }

            Console.WriteLine();
        }

        static void GuguShow2(int number)
        {
            int gugu_count = 1;
            while (gugu_count < 10)
            {
                Console.WriteLine($"{number} X {gugu_count} = {number * gugu_count}");
                gugu_count++;
            }
            Console.WriteLine();
        }

        static void Nsum(int number)
        {
            Console.WriteLine($"1부터 {number}까지의 합은? : {(number + 1) * number / 2}");
        }
        static void PrintNumber2(int number, int count)
        {
            int counter = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % number == 0)
                {
                    Console.Write("{0, 5}", i);
                    counter++;
                }

                if (counter == count)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
            Console.WriteLine();
        }

        static int ThreeMultipled(int x, int y, int z)
        {
            return x * y * z;
        }

        static double CircleArea(int radius = 0)
        {
            return radius * radius * 3.14;
        }

        static void gradePrint(int a = 0, int b = 0, int c = 0)
        {
            double ave = (double)(a + b + c) / 3;
            Console.WriteLine($"국어 : {a}, 영어 : {b}, 수학 : {c}");
            Console.WriteLine($"총점 : {a + b + c}, 평균 : {ave:f2} => {(ave >= 70 ? "합격" : "불합격")}");
        }

        static string PrintBMI(double height, double weight)
        {
            height /= 100;
            double bmi = weight / (height * height);
            String states_of_bmi;
            if (bmi < 20)
            {
                states_of_bmi = "저체중";
            }
            else if (bmi < 25)
            {
                states_of_bmi = "정상체중";
            }
            else if (bmi < 30)
            {
                states_of_bmi = "경도비만";
            }
            else if (bmi < 40)
            {
                states_of_bmi = "비만";
            }
            else
            {
                states_of_bmi = "고도비만";
            }
            return $"{bmi:f2} {states_of_bmi}";
        }

        static void HelloEveryone(params string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"{args[i]}님 안녕하세요!");
            }
            Console.WriteLine();
        }

        static string getMaxNumber(params double[] args)
        {
            if (args.Length == 0 || args.Length == 1)
            {
                return "오류발생";
            }
            return $"큰수는 ? {args.Max()}";
        }

        static void Calculator(int n, int m)
        {
            Console.WriteLine($"{n} + {m} = {n + m}");
            Console.WriteLine($"{n} - {m} = {n - m}");
            Console.WriteLine($"{n} * {m} = {n * m}");
            Console.WriteLine($"{n} / {m} = {n / m}");
        }
        static void Calculator(double x, double y, double z)
        {
            Console.WriteLine($"{x} + {y} + {z} = {x + y + z}");
            Console.WriteLine($"{x} - {y} - {z} = {x - y - z}");
            Console.WriteLine($"{x} * {y} * {z} = {x * y * z}");
            Console.WriteLine($"{x} / {y} / {z} = {x / y / z}");
        }

        static double GetArea(double radius)
        {
            return radius * radius * 3.14;
        }
        static double GetArea(double width, double height)
        {
            return width * height;
        }
        static double GetArea(double upper, double lower, double height)
        {
            return (upper + lower) * height / 2;
        }
        static void Main(string[] args)
        {
            // quiz 01
            Console.WriteLine("5의 배수 출력");
            PrintNumber();

            // quiz 02
            Console.WriteLine("구구단 함수 호출");
            GuguShow();

            // quiz 03
            Console.WriteLine("냉장고 함수 호출");
            Fridge();
            Console.WriteLine();

            // quiz 04
            Console.WriteLine("특정 구구단 출력하기");
            GuguShow2(2);
            Console.WriteLine();

            // quiz 05
            Nsum(100);
            Nsum(1000);
            Console.WriteLine();

            // quiz 06
            Console.WriteLine("특정 배수 출력하기");
            PrintNumber2(7, 7);
            PrintNumber2(3, 10);
            Console.WriteLine();

            // quiz 07
            Console.WriteLine("세 수 곱하기");
            Console.WriteLine($"3 * 4 * 5 = {ThreeMultipled(3, 4, 5)}");
            Console.WriteLine();

            // quiz 08
            Console.WriteLine("원의 넓이 구하기");
            Console.WriteLine(CircleArea());
            Console.WriteLine(CircleArea(12));
            Console.WriteLine(CircleArea(5));
            Console.WriteLine();

            // quiz 09
            gradePrint();
            gradePrint(90);
            gradePrint(90, 90);
            gradePrint(90, 90, 90);
            gradePrint(100, 40, 50);
            gradePrint(100, 70, 50);
            Console.WriteLine();

            // quiz 10
            Console.WriteLine($"고객 001 167.5cm, 55.7kg => BMI {PrintBMI(height: 167.5, weight: 55.7)}");
            Console.WriteLine($"고객 002 175.7cm, 77.5kg => BMI {PrintBMI(weight: 77.5, height: 175.7)}");
            Console.WriteLine($"고객 003 172.3cm, 76.1kg => BMI {PrintBMI(height: 172.3, weight: 76.1)}");
            Console.WriteLine();

            // quiz 11
            HelloEveryone("철수");
            HelloEveryone("철수", "영희");
            HelloEveryone("철수", "영희", "빌런", "히어로");
            Console.WriteLine();

            // quiz 12
            Console.WriteLine(getMaxNumber());
            Console.WriteLine(getMaxNumber(414));
            Console.WriteLine(getMaxNumber(15.91, 23.12));
            Console.WriteLine(getMaxNumber(151.91, 593.131, 523.123));
            Console.WriteLine(getMaxNumber(1, 2, 3, 4, 5, 6));
            Console.WriteLine();

            // quiz 13
            Calculator(10, 4);
            Calculator(101.14, 151.12, 62.1);
            Console.WriteLine();

            // quiz 14
            Console.WriteLine($"반지름이 2.5cm인 원의 넓이 = {GetArea(2.5)}");
            Console.WriteLine($"가로 5.5cm, 세로 6.5cm인 사각형의 넓이 = {GetArea(5.5, 6.5)}");
            Console.WriteLine($"윗변이 2.5cm, 아랫변이 4.3cm, 높이가 5.2cm인 원의 넓이 = {GetArea(2.5, 4.3, 5.2)}");

        }
    }
}
