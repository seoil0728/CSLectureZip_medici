using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // quiz 01
            Console.WriteLine("quiz 01");
            Console.WriteLine("가장 좋아하는 언어를 고르세요.");
            Console.WriteLine("1. C 2. C++ 3. C# 4. Python 5. JAVA 6. Go 7. Dart 8. Rust");
            string choise_language = Console.ReadLine();
            switch (choise_language)
            {
                case "1":
                    Console.WriteLine("C 선택");
                    break;
                case "2":
                    Console.WriteLine("C++ 선택");
                    break;
                case "3":
                    Console.WriteLine("C# 선택");
                    break;
                case "4":
                    Console.WriteLine("Python 선택");
                    break;
                case "5":
                    Console.WriteLine("JAVA 선택");
                    break;
                case "6":
                    Console.WriteLine("Go 선택");
                    break;
                case "7":
                    Console.WriteLine("Dart 선택");
                    break;
                case "8":
                    Console.WriteLine("Rust 선택");
                    break;
                default:
                    Console.WriteLine("잘못된 선택");
                    break;
            }
            Console.WriteLine();

            // quiz 02
            Console.WriteLine("quiz 02");
            Console.Write("점수를 입력하세요: ");
            int s = Convert.ToInt32(Console.ReadLine());
            string grade;

            switch (s)
            {
                case int n when (n >= 90):
                    grade = "A";
                    break;
                case int n when (n >= 80):
                    grade = "B";
                    break;
                case int n when (n >= 70):
                    grade = "C";
                    break;
                case int n when (n >= 60):
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine("학점은 {0}", grade);
            Console.WriteLine();


            // quiz03 lecture

            //Console.Write("점수를 입력하세요: ");
            //int s = Convert.ToInt32(Console.ReadLine());
            //// int s = 75;
            //string grade = "";
            //switch (s / 10)
            //{
            //    case 10: grade = "A"; break;
            //    case 9: grade = "A"; break;
            //    case 8: grade = "B"; break;
            //    case 7: grade = "C"; break;
            //    case 6: grade = "D"; break;
            //    default: grade = "F"; break;
            //}
            //Console.WriteLine("학점은 {0} = {1}, {2}", grade, s, s / 10);

            // quiz 03
            Console.WriteLine("quiz 03");
            Console.Write("출생 년도 입력 : ");
            int year = Convert.ToInt32(Console.ReadLine());
            int v1 = year % 12;
            string tea;

            switch (v1)
            {
                case 0:
                    tea = "원숭이";
                    break;
                case 1:
                    tea = "닭";
                    break;
                case 2:
                    tea = "개";
                    break;
                case 3:
                    tea = "돼지";
                    break;
                case 4:
                    tea = "쥐";
                    break;
                case 5:
                    tea = "소";
                    break;
                case 6:
                    tea = "호랑이";
                    break;
                case 7:
                    tea = "토끼";
                    break;
                case 8:
                    tea = "용";
                    break;
                case 9:
                    tea = "뱀";
                    break;
                case 10:
                    tea = "말";
                    break;
                case 11:
                    tea = "양";
                    break;
                default:
                    tea = "ur not human";
                    break;
            }
            Console.WriteLine($"{year}년생은 {tea}띠 입니다.");
            Console.WriteLine();

            // quiz 04
            Console.WriteLine("quiz 04");
            int gugu_count = 1;
            Console.Write("구구단 몇 단? : ");
            int gugu_start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (gugu_count < 10)
            {
                Console.WriteLine($"{gugu_start} X {gugu_count} = {gugu_start * gugu_count}");
                gugu_count++;
            }
            Console.WriteLine();

            // quiz 05
            Console.WriteLine("quiz 05");
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

            // quiz 06
            Console.WriteLine("quiz 06");
            string stocks = "";
            string stock;
            while (true)
            {
                Console.WriteLine("Q나 q를 입력하면 종료됩니다.");
                Console.Write("주식 종목 >> ");
                stock = Console.ReadLine();
                if (stock == "Q" || stock == "q")
                {
                    break;
                }
                stock += " ";
                stocks += stock;
            }
            Console.WriteLine("입력이 종료되었습니다.");
            Console.WriteLine($"보유 주식 종목 : {stocks}");
            Console.WriteLine();

            // quiz 07
            Console.WriteLine("quiz 07");
            int num = 1;
            int count_5 = 0;
            do
            {
                if (num % 3 == 0 || num % 11 == 0)
                {
                    Console.Write("{0, 4}", num);
                    count_5++;
                    if (count_5 % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                num++;
            } while (num < 101);
            if (count_5 % 5 != 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine("총 갯수 : {0}", count_5);
            Console.WriteLine();

            // quiz 08
            Console.WriteLine("quiz 08");
            Console.Write("구구단 몇 단? : ");
            int gugu_start_for = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{gugu_start_for} X {i} = {gugu_start_for * i}");
            }
            Console.WriteLine();

            // quiz 09
            Console.WriteLine("quiz 09");
            int count = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0, 2}\t", i);
                    count++;
                    if (count % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            if (count % 5 != 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 10
            Console.WriteLine("quiz 10");
            for (int i = 1; i < 6; i++)
            {
                Console.Write("{0}\t", i);
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 11
            Console.WriteLine("quiz 11");
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 12
            Console.WriteLine("quiz 12");
            for (int i = 4; i > -1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (5 - i) * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 13
            Console.WriteLine("quiz 13");
            string name_q13, id_q13;
            Console.Write("이름 : ");
            name_q13 = Console.ReadLine();
            Console.Write("아이디 : ");
            id_q13 = Console.ReadLine();
            Console.WriteLine("_____________");
            Console.Write("이름 : ");
            for (int i = 0; i < name_q13.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(name_q13[i]);
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.Write("아이디 : ");
            for (int i = 0; i < id_q13.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.Write(id_q13[i]);
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine(id_q13[id_q13.Length - 1]);
            Console.WriteLine();

            // quiz 14
            Console.WriteLine("quiz 14");
            string word = "apple apart ant apply aribaba";
            foreach (var c in word)
            {
                if (c == 'a' || c == 'l')
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
