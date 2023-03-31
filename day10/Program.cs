using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // quiz 01
            string[] starr = { "one", "two", "three" };
            Queue queue = new Queue(starr);
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine(queue.Dequeue());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error : {e.Message}");
                }
            }
            Console.WriteLine("Test End");
            Console.WriteLine();

            // quiz 02
            ArrayList arli = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write("type int data : ");
                    arli.Add(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Type Error : {e.Message}");
                }
            }
            Console.Write("Num_list = ");
            foreach (int i in arli)
                Console.Write($"{i} ");
            Console.WriteLine();
            Console.WriteLine();


            // throw test
            int test_data = 15;
            try
            {
                if (test_data > 10)
                {
                    throw new Exception("test_data must lower than 10");
                }
                else
                {
                    Console.WriteLine("test_data is Allowed");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            { 
                Console.WriteLine("Throw Test"); 
            }
            Console.WriteLine();


            // quiz 03
            string[] nancy = File.ReadAllLines("C:\\CSLecture\\CSLectureZip\\day10\\data\\nancy.txt");
            for (int i = 0;i < nancy.Length;i++)
            {
                Console.WriteLine($"{i + 0} Line : {nancy[i]}");
            }

            // quiz 04
            StreamReader sr = new StreamReader("C:\\CSLecture\\CSLectureZip\\day10\\data\\score_data.txt");
            double sum = 0;
            double count = 0;
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;
                sum += Convert.ToInt32(line);
                count++;
            }
            Console.WriteLine($"Average = {sum/count}");

            // quiz 05
            using (StreamWriter sw = new StreamWriter("C:\\CSLecture\\CSLectureZip\\day10\\data\\gugu.txt"))
            {
                for (int i = 2; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        sw.WriteLine($"{i} X {j} = {i * j}");
                    }
                }
            }
                
        }
    }
}
