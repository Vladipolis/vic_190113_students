using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    class Student:Person
    {
        protected int course;
        public int Course
        {
            set { course = value; }
            get { return course; }
        }
        protected int[] marks;
        public int[] Marks
        {
            set { marks = value; }
            get { return marks; }
        }

        public Student() : base() //Вызываем конструктор базового класса
        {
            Course = -1;
            Marks = null;
        }
        public Student(string n, string s, double a) : base(n, s, a) //Вызываем конструктор базового класса
        {
            Course = -1;
            Marks = null;
        }
        public Student(string n, string s, double a, int c) : base(n, s, a) //Вызываем конструктор базового класса
        {
            Course = c;
            Marks = null;
        }
        public Student(string n, string s, double a, int c, int[] m) : base(n, s, a) //Вызываем конструктор базового класса
        {
            Course = c;
            Marks = m;
        }
        public Student(Person per, int c)
        {
            Name = per.Name;
            Sex = per.Sex;
            Age = per.Age;
            Course = c;
            Marks = null;
        }
        public Student(Person per, int c, int[] m)
        {
            Name = per.Name;
            Sex = per.Sex;
            Age = per.Age;
            Course = c;
            Marks = m;
        }

        override public void Show()
        {

            Console.WriteLine($"Name: {Name} | Sex: {Sex} | Age: {Age} | Course: {Course}");
            Console.Write($"Marks of {Name}: ");
            for (int i = 0; i < Marks.Length; i++)
                Console.Write(Marks[i].ToString() + " | ");
            Console.Write("\n");
        }

        public void CountAverageMark ()
        {
            int sum=0;
            if (Marks != null)
            {
                for (int i = 0; i < Marks.Length; i++)
                {
                    sum += Marks[i];
                }
                if (sum > 0)

                {
                    Console.WriteLine($"Average mark for student {Name} is: {sum*1.0 / Marks.Length}");
                }
            }
            
        }

    }
}
