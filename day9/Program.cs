using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    class Name_card
    {
        private string Name;
        private int Age;

        public string name
        {
            get { return this.Name; }
            set
            {
                if (value.Length >= 2)
                    this.Name = value;
                else
                    this.Name = "Unknown";
            }
        }
        public int age
        {
            get { return this.Age; }
            set
            {
                if (value > 0)
                    this.Age = value;
                else this.Age = 0;
            }
        }
    }
    class Student
    {
        private int Id;
        private int Grade;
        private char Gender;

        public int id
        {
            get { return this.Id; }
            set
            {
                if ((value < 3000) || (value > 3999))
                    this.Id = 0;
                else this.Id = value;
            }
        }
        public int grade
        {
            get { return this.Grade; }
            set
            {
                if (value > 4 || value < 1)
                    this.Grade = 0;
                else this.Grade = value;
            }
        }

        public char gender
        {
            get { return this.Gender; }
            set
            {
                if (value == 'F' || value == 'M')
                    this.Gender = value;
                else this.Gender = 'U';
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Property : Get Set");
            Console.WriteLine("Example Code (class Name_card)");
            Console.WriteLine("=============================");
            Name_card nc = new Name_card();
            nc.name = "오";
            nc.age = -99;
            Console.WriteLine($"이름 = {nc.name}");
            Console.WriteLine($"나이 = {nc.age}");

            // quiz 01
            Console.WriteLine("quiz01");
            Student st1 = new Student();
            st1.id = 3500;
            st1.grade = 3;
            st1.gender = 'F';
            Console.WriteLine($"ID = {st1.id}, Grade = {st1.grade}, Gender = {st1.gender}");
            Student st2 = new Student();
            st2.id = 100;
            st2.grade = 6;
            st2.gender = 'B';
            Console.WriteLine($"ID = {st2.id}, Grade = {st2.grade}, Gender = {st2.gender}");
            Console.WriteLine();

            // quiz 02
            ArrayList arli = new ArrayList();
            Console.Write("Type Food you like : ");
            arli.Add(Console.ReadLine());
            Console.Write("Type Movie : ");
            arli.Add(Console.ReadLine());
            Console.Write("Type Singer : ");
            arli.Add(Console.ReadLine());
            Console.Write("Type Number : ");
            arli.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Type city : ");
            arli.Add(Console.ReadLine());
            Console.WriteLine($"Your List = [{arli[0]}, {arli[1]}, {arli[2]}, {arli[3]}, {arli[4]}]");
            Console.Write("Your List = [");
            for (int i = 0; i < arli.Count; i++)
            {
                if (arli[i].GetType() == "b".GetType())
                    Console.Write($"\'{arli[i]}\'");
                else
                    Console.Write(arli[i].ToString());
                if (i < arli.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
            Console.WriteLine();

            // quiz 03
            //{"사과", "망고","치즈케이크","주스"}
            string[] arr = { "사과", "망고", "치즈케이크", "주스" };
            ArrayList fridge = new ArrayList(arr);
            Console.WriteLine($"Our Fridge = {string.Join(", ", fridge.ToArray())}");
            Console.WriteLine("Someone ate 사과");
            fridge.Remove("사과");
            Console.WriteLine($"Our Fridge = {string.Join(", ", fridge.ToArray())}");
            Console.WriteLine("Someone get 수박");
            fridge.Add("수박");
            Console.WriteLine($"Our Fridge = {string.Join(", ", fridge.ToArray())}");
            Console.WriteLine("Someone ate 치즈케이크, 수박");
            fridge.Remove("치즈케이크");
            fridge.Remove("수박");
            Console.WriteLine($"Our Fridge = {string.Join(", ", fridge.ToArray())}");
            Console.WriteLine();

            // quiz 04
            string score = "도레미파솔라시";
            Stack st = new Stack(score.ToArray());
            Console.WriteLine($"{st.Pop()} = {st.Pop()} = {st.Pop()} = {st.Pop()} = {st.Pop()} = {st.Pop()} = {st.Pop()} = ");
            Console.WriteLine();

            // quiz 05
            int[] multiThree = new int[15];
            for (int i = 0; i < 15; i++)
                multiThree[i] = (i + 1) * 3;
            Queue<int> queueThree = new Queue<int>(multiThree);
            foreach (int i in multiThree)
                Console.Write($"^{queueThree.Dequeue()} ");
            Console.WriteLine();
            Console.WriteLine();

            // quiz 06
            string myWord = "banana fruit orange apple mango";
            Hashtable ht = new Hashtable();
            foreach (string w in myWord.Split())
                ht[w[0]] = w;
            Console.WriteLine(ht["b"]);
            Console.WriteLine(ht["f"]);
            Console.WriteLine(ht["o"]);
            Console.WriteLine(ht["a"]);
            Console.WriteLine(ht["m"]);

        }
    }
}
