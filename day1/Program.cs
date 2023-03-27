using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello, CSharp!");

            // 주석 처리 = ctrl + k, ctrl + c
            // 주석 해제 = ctrl + k, ctrl + u

            Console.WriteLine("Block");
            Console.Write("In-line");
            Console.WriteLine();

            // Escape Character
            Console.WriteLine("test1 \t test2 \n test3 \'test4\' \"test5\"");

            // index {} need index number
            Console.WriteLine("Index {0} Test {1}", "Number1", "Number2");

            // $
            int v1 = 3;
            String s1 = "Ss";
            Console.WriteLine($"v1 = {v1}, s1 = {s1}");

            // GetType
            Console.WriteLine("v1 type is {0}", v1.GetType());
            Console.WriteLine("s1 type is {0}", s1.GetType());
            Console.WriteLine();


            // string interpolation
            String si1 = String.Format("{0} and {1}", "Test1", "Test2");
            String si2 = String.Format($"Test1 code {v1} and Test2 code {s1}");
            String si3 = $"v1 = {v1}, s1 = {s1}";
            Console.WriteLine(si1);
            Console.WriteLine(si2);
            Console.WriteLine(si3);
            Console.WriteLine();

            // Console.ReadLine() : user input in string
            // Console.ReadKey() : return key that user type
            Console.WriteLine("키를 입력해보세요.");
            ConsoleKeyInfo user_key = Console.ReadKey();
            Console.WriteLine($"입력 키 정보 : {user_key.Key}");
            Console.WriteLine();


            // explicit casting
            long l1 = long.MaxValue;
            int ll1 = (int)l1;
            Console.WriteLine($"long to int explicit casting");
            Console.WriteLine($"l1 = {l1}, casting to int = {ll1}");

            // binary, oct, hex
            int y1 = 100;
            Console.WriteLine($"binary of {y1} = {Convert.ToString(y1, 2)}");
            Console.WriteLine($"oct of {y1} = {Convert.ToString(y1, 8)}");
            Console.WriteLine($"hex of {y1} = {Convert.ToString(y1, 16)}");

            // PadLeft
            Console.WriteLine($"Padding Left = {y1.ToString().PadLeft(8, '0')}");
            Console.WriteLine();

            // var = 암시적 변수 지정
            var q1 = 10;
            var q2 = "ga";
            var q3 = 3.141592;
            var q4 = false;
            Console.WriteLine(q1.GetType());
            Console.WriteLine(q2.GetType());
            Console.WriteLine(q3.GetType());
            Console.WriteLine(q4.GetType());
            Console.WriteLine();

            // default = 해당 변수의 초기값으로 자동 지정
            int d1 = default;
            String d2 = default;
            bool d3 = default;
            float d4 = default;
            char d5 = default;
            Console.WriteLine($"{d1}, {d2}, {d3}, {d4}, {d5}");
            Console.WriteLine();

            // string method
            // 문자열 탐색 메소드
            // 문자열변수.메소드(옵션)
            string sampleTxt1 = "Good Morning";
            string sampleTxt2 = "가나다라마바사아자차카타파하";
            Console.WriteLine($"\t sampleTxt1 = {sampleTxt1}");
            Console.WriteLine($"\t sampleTxt2 = {sampleTxt2}");
            Console.WriteLine($"\t 마지막 o의 인덱스 위치 = {sampleTxt1.LastIndexOf("o")}");
            Console.WriteLine($"\t 첫번째 o의 인덱스 위치 = {sampleTxt1.StartsWith("o")}");
            Console.WriteLine($"\t a로 시작하는가? {sampleTxt1.StartsWith("a")}");
            Console.WriteLine($"\t G로 시작하는가? {sampleTxt1.StartsWith("G")}");
            Console.WriteLine($"\t G로 끝나는가? {sampleTxt1.EndsWith("G")}");
            Console.WriteLine($"\t ing로 끝나는가? {sampleTxt1.EndsWith("ing")}");
            Console.WriteLine($"\t 차가 포함되었는가? {sampleTxt2.Contains("차")}");
            Console.WriteLine($"\t Morning 글자 교체 {sampleTxt1.Replace("Morning", "Night")}");
            Console.WriteLine($"\t sampleTxt1 = {sampleTxt1}");
            // 새로운 값으로 교체하려면?
            sampleTxt1 = sampleTxt1.Replace("Morning", "Night");
            Console.WriteLine($"\t sampleTxt1 = {sampleTxt1}");

            Console.WriteLine("\t Insert = {0}", sampleTxt1.Insert(0, "***"));
            Console.WriteLine();

            // string formatting
            String sample = "abcedfg";
            // Padding left : n > 0, Padding right : n < 0
            Console.WriteLine("*{0, 20}*", sample);
            Console.WriteLine("*{0, -20}*", sample);
            Console.WriteLine("1234*{0, 20}*1234", sample);
            Console.WriteLine("1234*{0, -20}*1234", sample);
            Console.WriteLine();

            // number formatting
            Console.WriteLine("\t 10진수 => {0:D10}", 12345);
            Console.WriteLine("\t 16진수 => {0}", 0x32A);
            Console.WriteLine("\t 16진수 => 0X{0:X}", 0x32A);
            Console.WriteLine("\t 16진수 => 0X{0:X10}", 0x32A);
            Console.WriteLine("\t N => {0:N}", 1234567890);
            Console.WriteLine("\t N0 => {0:N0}", 1234567890);
            Console.WriteLine("\t N1 => {0:N1}", 1234567890);
            Console.WriteLine("\t N3 => {0:N3}", 1234567890);
            Console.WriteLine();

            Console.WriteLine("\t F => {0:F}", 1234.5678);
            Console.WriteLine("\t F => {0:F3}", 1234);
            Console.WriteLine("\t F => {0:F0}", 1234.5678);
            Console.WriteLine("\t E => {0:E}", 1234.5678);
            Console.WriteLine("\t E => {0:E2}", 1234.5678);
            Console.WriteLine("\t E => {0:E5}", 1234.5678);







            // quiz 01
            Console.WriteLine("Hello World의 유래는?");
            Console.WriteLine();
            Console.WriteLine("C 와 UNIX를 개발한\n브라이언 커니핸과 데니스 리치가\n쓴 THE C Program Language 교재에\n첫 예제가 Hello World! 출력 이였다.\n");
            Console.WriteLine("해당 교재가 유명해지면서\n모든 프로그래밍 첫 예제가\nHello World 출력으로 시작하게 되었다.\n");

            // quiz 02
            Console.WriteLine("*\n**\n***\n****\n*****");

            // quiz 03
            Console.WriteLine("2019\n\t{0}, {1}, {2}, {3}, {4}", "JAVA", "C", "Python", "C++", "C#");
            Console.WriteLine("2050\n\t{2}, {4}, {1}, {3}, {0}", "JAVA", "C", "Python", "C++", "C#");

            // quiz 04
            float pi = 3.14f;
            int radius = 5;
            Console.WriteLine($"원의 반지름 = {radius}");
            Console.WriteLine($"원의 넓이 = {pi * radius * radius}");
            Console.WriteLine($"원의 둘레 = {2 * pi * radius}");

            // quiz 05
            Console.WriteLine($"float 자료형 최댓값 : {float.MaxValue} 최솟값 : {float.MinValue}");
            Console.WriteLine($"byte 자료형 최댓값 : {byte.MaxValue} 최솟값 : {byte.MinValue}");
            Console.WriteLine($"ulong 자료형 최댓값 : {ulong.MaxValue} 최솟값 : {ulong.MinValue}");
            Console.WriteLine($"short 자료형 최댓값 : {short.MaxValue} 최솟값 : {short.MinValue}");

            // quiz 06
            String unse = @"2023.03.20일 돼지띠 운세

능숙하게 자신의 감정을 억제하지 못해서 트러블이 발생해 버릴 것 같은 날입니다.
특히 이성에 대해서는, 약간의 변덕으로 말했던 것이 깊게 상대를 상처 입혀 버리므로, 조심합시다.
착각으로 말을 하여 산대를 실망을 시킬 수 있으니 주의가 필요합니다.
또, 교제 범위가 넓히기 위해서 체력적으로 따라갈 수 없게 될 것 같기 때문에, 건강에는 신경을 씁시다.

금전운 : 6
무엇인가 지출이 늘어나 버릴 것 같은 하루.

사업운 : 6
타인의 평가를 너무 신경쓰지 않게.";

            Console.WriteLine(unse);

            // quiz 07
            const float MAX_FLOAT = float.MaxValue;
            const float MIN_FLOAT = float.MinValue;
            Console.WriteLine($"float 자료형의 최댓값 = {MAX_FLOAT}\nfloat 자료형의 최솟값 = {MIN_FLOAT}");

            // quiz 08
            Console.Write("사각형의 가로 길이를 숫자로 입력해 주세요 ... ");
            int read01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("사각형의 세로 길이를 숫자로 입력해 주세요 ... ");
            int read02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"사각형의 가로 길이 = {read01}");
            Console.WriteLine($"사각형의 세로 길이 = {read02}");
            Console.WriteLine($"사각형의 넓이 = {read01 * read02}");


            // quiz 09
            Console.Write("정수 입력 >> ");
            int vint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("====================");
            Console.WriteLine("출력".PadLeft(18, ' '));
            Console.WriteLine("====================");
            Console.WriteLine($"\t2진수 = {Convert.ToString(vint, 2)}");
            Console.WriteLine($"\t8진수 = {Convert.ToString(vint, 8)}");
            Console.WriteLine($"\t16진수 = {Convert.ToString(vint, 16)}");

        }
    }
}
