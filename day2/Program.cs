using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 / 2 = {0}", (5 / 2));
            Console.WriteLine("5.0 / 2 = {0}", 5.0 / 2);
            Console.WriteLine("5 / 2.0 = {0}", 5 / 2.0);
            Console.WriteLine("5.0 / 2.0 = {0}", 5.0 / 2.0);

            Console.WriteLine("5 % 2 = {0}", 5 % 2);
            Console.WriteLine("5.0 % 2 = {0}", 5.0 % 2);
            Console.WriteLine("5 % 2.0 = {0}", 5 % 2.0);
            Console.WriteLine("5.0 % 2.0 = {0}", 5.0 % 2.0);
            Console.WriteLine();

            // quiz 01
            Console.WriteLine("Quiz 01");
            Console.Write("첫 번째 숫자를 입력해 주세요 : ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("두 번째 숫자를 입력해 주세요 : ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
            Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            Console.WriteLine($"{v1} * {v2} = {v1 * v2}");
            Console.WriteLine($"{v1} / {v2} = {v1 / v2}");
            Console.WriteLine($"{v1} % {v2} = {v1 % v2}");
            Console.WriteLine();

            // quiz 02
            Console.WriteLine("Quiz 02");
            Console.Write("교환할 돈을 입력해주세요 : ");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"500원짜리 : {money / 500}");
            money %= 500;
            Console.WriteLine($"100원짜리 : {money / 100}");
            money %= 100;
            Console.WriteLine($"50원짜리 : {money / 50}");
            money %= 50;
            Console.WriteLine($"10원짜리 : {money / 10}");
            Console.WriteLine($"바꾸지 못한 잔돈 : {money % 10}");
            Console.WriteLine();


            // quiz 03
            Console.WriteLine("Quiz 03");
            Console.Write("비밀번호 입력 : ");
            string passward = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(passward == "1234");
            Console.WriteLine();

            // quiz 04
            Console.WriteLine("Quiz 04");
            Console.Write("철수의 키는? : ");
            int tall_of_cs = Convert.ToInt32(Console.ReadLine());
            Console.Write("철수의 나이는? : ");
            int age_of_cs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"철수는 놀이기구를 탈 수 있을까? {tall_of_cs >= 150 && age_of_cs >= 10}");
            Console.WriteLine();

            // quiz 05
            Console.WriteLine("Quiz 05");
            Console.Write("정수 숫자 입력 : ");
            int v3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{v3}는 짝수인가요? {v3 % 2 == 0}");
            Console.WriteLine();

            // quiz 06
            Console.WriteLine("Quiz 06");
            int a, b, c;
            Console.WriteLine("정수를 세 번 입력하세요.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            bool b1 = a + b + c > 500;
            bool b2 = a % 2 == 0 && b % 2 == 0 && c % 2 == 0;
            Console.WriteLine($"세 수의 합은 500보다 큰가? {b1}");
            Console.WriteLine($"세 수는 모두 짝수인가? {b2}");
            Console.WriteLine($"세 수의 합은 500보다 크고 세 수는 모두 짝수인가? {b1 && b2}");
            Console.WriteLine();

            // quiz 07
            Console.WriteLine("Quiz 07");
            Console.Write("철수 쿠폰 갯수 입력 : ");
            int coupon_cs = Convert.ToInt32(Console.ReadLine());
            Console.Write("영희 쿠폰 갯수 입력 : ");
            int coupon_yh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"치킨을 먹을 수 있을까? {coupon_cs + coupon_yh >= 10}");
            Console.WriteLine();

            // quiz 08
            Console.WriteLine("Quiz 08");
            Console.Write("철수의 키는? : ");
            tall_of_cs = Convert.ToInt32(Console.ReadLine());
            Console.Write("철수의 나이는? : ");
            age_of_cs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string msg = (tall_of_cs >= 150 && age_of_cs >= 10) ? "탈수 있다." : "탈 수 없다.";
            Console.WriteLine($"철수는 놀이기구를 탈 수 있을까? {msg}");
            Console.WriteLine();

            // quiz 09
            Console.WriteLine("Quiz 09");
            Console.Write("숫자를 입력해주세요 : ");
            int v4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{v4}는 {(v4 % 2 == 0 ? "짝수" : "홀수")}");
            Console.WriteLine(v4 % 3 == 0 && v4 % 7 == 0 ? $"{v4}는 3과 7의 배수" : "");
            Console.WriteLine();

            // quiz 10
            Console.WriteLine("Quiz 10");
            int v5, v6;
            Console.Write("첫 번째 수 입력 : ");
            v5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 수 입력 : ");
            v6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (v5 == v6)
            {
                Console.WriteLine("입력 숫자가 같다.");
            }
            else
            {
                Console.WriteLine(v5 > v6 ? $"첫 번째 수 {v5}가 크다." : $"두 번째 수 {v6}가 크다.");
            }
            Console.WriteLine();

            // quiz 11
            Console.WriteLine("Quiz 11");
            Console.Write("점수 : ");
            int score = Convert.ToInt32(Console.ReadLine());
            if (score < 70)
            {
                Console.WriteLine($"{score}점. 수고하셨습니다.");
            }
            else
            {
                Console.WriteLine("축하합니다.");
                if (score < 80)
                {
                    Console.WriteLine("동메달을 수상하셨습니다.");
                }
                else if (score < 90)
                {
                    Console.WriteLine("은메달을 수상하셨습니다.");
                }
                else
                {
                    Console.WriteLine("금메달을 수상하셨습니다.");
                }
            }

            Console.WriteLine();

            // quiz 12
            Console.WriteLine("Quiz 12");
            double tall, weight;
            Console.Write("키를 입력하세요. (cm) : ");
            tall = Convert.ToDouble(Console.ReadLine()) * 0.01;
            Console.Write("체중을 입력하세요 (kg) : ");
            weight = Convert.ToDouble(Console.ReadLine());
            double bmi = Math.Round(weight / (tall * tall), 1);
            Console.WriteLine();
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
            Console.WriteLine($"BMI = {bmi}, {states_of_bmi}입니다.");

        }
    }
}
