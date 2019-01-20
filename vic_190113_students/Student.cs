using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    class Student : Person
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
        public Student(string n, string s, double a, int c, int[] mrks) : base(n, s, a) //Вызываем конструктор базового класса
        {
            Course = c;
            Marks = mrks;
        }
        public Student(Person per, int crs)
        {
            Name = per.Name;
            Sex = per.Sex;
            Age = per.Age;
            Course = crs;
            Marks = null;
        }
        public Student(Person per, int crs, int[] mrks)
        {
            Name = per.Name;
            Sex = per.Sex;
            Age = per.Age;
            Course = crs;
            Marks = mrks;
        }

        public void CountAverageMark()
        {
            int sum = 0;
            if (Marks != null)
            {
                for (int i = 0; i < Marks.Length; i++)
                {
                    sum += Marks[i];
                }
                if (sum > 0)

                {
                    Console.WriteLine($"Average mark for student {Name} is: {sum * 1.0 / Marks.Length}");
                }
            }

        }

        //Cтудент сдал на отлично?
        public bool IsExcellentStudent()
        {
            int count = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                if (Marks[i] == 5)
                    count++;
            }
            if (count == Marks.Length)
                return true;
            else
                return false;

        }

        public override string ToString()
        {
            string str = base.ToString();
            str += $"Course: {Course}. Marks: ";
            for (int i=0; i<Marks.Length;i++)
            {
                str += Marks[i].ToString() + " ";
            }
            return str;
        }
        //override public void Show()
        //{
        //    base.Show();
        //    Console.WriteLine($"Name: {Name} | Sex: {Sex} | Age: {Age} | Course: {Course}");
        //    Console.Write($"Marks of {Name}: ");
        //    for (int i = 0; i < Marks.Length; i++)
        //        Console.Write(Marks[i].ToString() + " | ");
        //    Console.Write("\n");
        //}
        override public void Show()
        {
            base.Show();
            Console.WriteLine(ToString());
        }

        //Переопределяем иквал для сравнения
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && (this.Course == ((Student)obj).Course);
            
        }
    }
}
