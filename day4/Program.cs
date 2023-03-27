using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    enum PL
    {
        C_language = 10,
        C_Plus = 20,
        C_Sharp = 30,
        Python = 40,
        JAVA = 50
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // quiz 01
            Console.WriteLine("quiz 01");
            int[] scoreArr = { 65, 77, 55 };
            int sum_arr = 0;
            foreach (int score in scoreArr)
            {
                sum_arr += score;
            }
            Console.WriteLine($"총점 = {sum_arr}");
            Console.WriteLine($"평균 = {(sum_arr / scoreArr.Length):f3}");
            Console.WriteLine();

            // quiz 02
            Console.WriteLine("quiz 02");
            string[] countryArr = new string[7];
            for (int i = 0; i < countryArr.Length; i++)
            {
                Console.Write("{0}번째 배열값 : ", i);
                countryArr[i] = Console.ReadLine();
            }
            for (int i = 0; i < countryArr.Length; i++)
            {
                Console.WriteLine(countryArr[i]);
            }

            Console.WriteLine();

            // quiz 03
            Console.WriteLine("quiz 03");
            string[] names = { "민호", "민수", "영희", "철수", "승호" };
            Console.WriteLine($"첫 번째 배열값 출력 : {names[0]}");
            Console.WriteLine($"세 번째 배열값 출력 : {names[2]}");
            Console.WriteLine("배열 모두 출력하기");
            foreach (string name in names)
            {
                Console.WriteLine($"==> {name}");
            }

            Console.WriteLine();

            // quiz 04
            Console.WriteLine("quiz 04");
            Console.Write("배열의 길이 입력 : ");
            int len_arr = Convert.ToInt32(Console.ReadLine());
            string[] arr_str = new string[len_arr];
            Console.WriteLine();
            for (int i = 0; i < len_arr; i++)
            {
                Console.Write("{0} 배열 값 : ", i);
                arr_str[i] = Console.ReadLine();
            }
            Console.WriteLine();
            foreach (string name in arr_str)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // quiz 05
            Console.WriteLine("quiz 05");
            int[] scores = new int[5];
            string[] subTitle = { "국어", "영어", "수학", "과학", "사회" };
            for (int i = 0; i < subTitle.Length; i++)
            {
                Console.Write("{0} 점수 : ", subTitle[i]);
                int score = Convert.ToInt32(Console.ReadLine());
                scores[i] = score;
            }
            int sum_of_scores = 0;
            foreach (int s in scores)
            {
                sum_of_scores += s;
            }
            Console.WriteLine($"합계 = {sum_of_scores}");
            Console.WriteLine($"평균 = {((double)sum_of_scores / scores.Length):f3}");
            if ((double)sum_of_scores / scores.Length > 90)
            {
                Console.WriteLine("학점은 A");
            }
            else if ((double)sum_of_scores / scores.Length > 80)
            {
                Console.WriteLine("학점은 B");
            }
            else if ((double)sum_of_scores / scores.Length > 70)
            {
                Console.WriteLine("학점은 C");
            }
            else if ((double)sum_of_scores / scores.Length > 60)
            {
                Console.WriteLine("학점은 D");
            }
            else
            {
                Console.WriteLine("학점은 F");
            }
            Console.WriteLine();

            // quiz 06
            Console.WriteLine("quiz 06");
            string[,] userInfo = {
                { "홍길동","gildong"," 남"},
                { "신은주","eunju67"," 여"},
                { "김수홍","su7836"," 남"},
                { "최민호","minho6"," 남"},
                { "이수진","sujun77"," 여"}
            };
            Console.WriteLine("이름\t아이디\t성별");
            Console.WriteLine();
            for (int i = 0; i < userInfo.GetLength(0); i++)
            {
                for (int j = 0; j < userInfo.GetLength(1); j++)
                {
                    Console.Write(userInfo[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 07
            Console.WriteLine("quiz 07");
            int[,] array_5m = new int[5, 5];
            int multiple_5 = 5;
            for (int i = 0; i < array_5m.GetLength(0); i++)
            {
                for (int j = 0; j < array_5m.GetLength(1); j++)
                {
                    array_5m[i, j] = multiple_5;
                    multiple_5 += 5;
                }
            }
            for (int i = 0; i < array_5m.GetLength(0); i++)
            {
                for (int j = 0; j < array_5m.GetLength(1); j++)
                {
                    Console.Write(array_5m[i, j].ToString().PadLeft(5, ' '));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 08
            Console.WriteLine("quiz 08");
            int[,] equal_arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        equal_arr[i, j] = 1;
                    }
                    else
                    {
                        equal_arr[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < equal_arr.GetLength(0); i++)
            {
                for (int j = 0; j < equal_arr.GetLength(1); j++)
                {
                    Console.Write(equal_arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 09
            Console.WriteLine("quiz 09");
            int[,] middle_scores =
            {
                { 55, 88 }, { 80, 78 }, { 95, 77 }
            };
            string[] student_names = { "최은우", "마동탁", "박지민" };
            float[,] middle_scores2 = new float[3, 4];
            Console.WriteLine("-------------");
            Console.WriteLine("\t국어 영어");
            for (int i = 0; i < student_names.Length; i++)
            {
                Console.Write(student_names[i] + "\t");
                for (int j = 0; j < middle_scores.GetLength(1); j++)
                {
                    Console.Write(" " + middle_scores[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < middle_scores2.GetLength(0); i++)
            {
                for (int j = 0; j < middle_scores2.GetLength(1); j++)
                {
                    if (j < 2)
                    {
                        middle_scores2[i, j] = (float)middle_scores[i, j];
                    }
                    else
                    {
                        if (j == 2)
                        {
                            middle_scores2[i, j] = middle_scores2[i, 0] + middle_scores2[i, 1];
                        }
                        else
                        {
                            middle_scores2[i, j] = middle_scores2[i, 2] / (float)middle_scores.GetLength(1);
                        }
                    }
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine("학생명\t국어\t영어\t총점\t평균");
            for (int i = 0; i < student_names.Length; i++)
            {
                Console.Write(student_names[i] + "\t");
                for (int j = 0; j < middle_scores2.GetLength(1); j++)
                {
                    Console.Write($"{(middle_scores2[i, j]):f2}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // quiz 10
            Console.WriteLine("quiz 10");
            Console.WriteLine("01. " + Season.Spring);
            Console.WriteLine("02. " + Season.Summer);
            Console.WriteLine("03. " + Season.Autumn);
            Console.WriteLine("04. " + Season.Winter);
            Console.WriteLine();

            // quiz 11
            Console.WriteLine("quiz 11");
            Console.WriteLine("Num\tEnum");
            Console.WriteLine("==================");
            Console.WriteLine($"{(int)PL.C_language}\t{PL.C_language}");
            Console.WriteLine($"{(int)PL.C_Plus}\t{PL.C_Plus}");
            Console.WriteLine($"{(int)PL.C_Sharp}\t{PL.C_Sharp}");
            Console.WriteLine($"{(int)PL.Python}\t{PL.Python}");
            Console.WriteLine($"{(int)PL.JAVA}\t{PL.JAVA}");
        }
    }
}
