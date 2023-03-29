using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    abstract class Animal
    {
        public void Run()
        {
            Console.WriteLine("is Running Very Fast.");
        }
        public abstract void Hunt(string what, string where);

        public abstract void Sleep(int time, string where);
    }

    class Tiger : Animal
    {
        public override void Hunt(string what, string where)
        {
            Console.WriteLine($"Tiger is Hunting {what} in {where}");
        }
        public override void Sleep(int time, string where)
        {
            Console.WriteLine($"Tiger slept {time} Hours in {where}");
        }
    }

    class Cat : Animal
    {
        public override void Hunt(string what, string where)
        {
            Console.WriteLine($"Cat is Hunting {what} in {where}");
        }
        public override void Sleep(int time, string where)
        {
            Console.WriteLine($"Cat slept {time} Hours in {where}");
        }
    }

    interface IDino
    {
        void Eat(string what);
        void Sleep(string where);
        void Play(int num);
        void Today(string what, int num, string where);
    }

    class Tyrano : IDino
    {
        public string name;

        public void Eat(string what) 
        {
            Console.WriteLine($"{this.name} Eat {what}");
        }
        public void Sleep(string where)
        {
            Console.WriteLine($"{this.name} Slept in {where}");
        }
        public void Play(int num)
        {
            Console.WriteLine($"{this.name} play with {num} friends");
        }
        public void Today(string what, int num, string where)
        {
            Eat(what);
            Sleep(where);
            Play(num);
        }
    }

    interface ITiger
    {
        void Jump();
        void Cry_Tiger();
    }

    interface ILion
    {
        void Bite();
        void Cry_Lion();
    }
    interface ILiger : ITiger, ILion
    {
        void Play();
    }
    class Liger : ILiger
    {
        public string name;
        public Liger(string name)
        {
            this.name = name;
        }
        public void Bite()
        {
            Console.WriteLine($"{this.name} Bite Like Lion.");
        }
        public void Jump()
        {
            Console.WriteLine($"{this.name} Jump Like Tiger");
        }
        public void Cry_Tiger()
        {
            Console.WriteLine($"{this.name} Crying Like Tiger");
        }
        public void Cry_Lion()
        {
            Console.WriteLine($"{this.name} Crying Like Lion");
        }
        public void Play()
        {
            Console.WriteLine($"{this.name} Playing with people");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // quiz 01
            Tiger t1 = new Tiger();
            t1.Run();
            t1.Hunt("Deer", "Forest");
            t1.Sleep(7, "Cave");
            Console.WriteLine();

            Cat c1 = new Cat();
            c1.Run();
            c1.Hunt("Fish", "River");
            c1.Sleep(20, "Home");

            Console.WriteLine();

            // quiz 02
            Tyrano titi = new Tyrano();
            titi.name = "titi";
            titi.Today("GM", 0, "Home");
            Console.WriteLine();

            // quiz 03
            Liger lig = new Liger("Lig");
            lig.Jump();
            lig.Cry_Lion();
            lig.Cry_Tiger();
            lig.Bite();
            lig.Play();
            lig.Play();
        }
    }
}
