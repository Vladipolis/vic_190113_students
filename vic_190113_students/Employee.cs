using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    class Employee:Person
    {
        protected string title;
        public string Title
        {
            set { title = value; }
            get { return title; }
        }

        public Employee() : base() //Вызываем конструктор базового класса
        {
            Title = "ERROR";
        }
        public Employee(string n, string s, double a) : base(n, s, a) //Вызываем конструктор базового класса
        {
            Title = "ERROR";
        }
        public Employee(string n, string s, double a, string t) : base(n, s, a) //Вызываем конструктор базового класса
        {
            Title = t;
        }
        public Employee(Person per, string t)
        {
            Name = per.Name;
            Sex = per.Sex;
            Age = per.Age;
            Title = t;
        }

        override public void Show()
        {

            Console.WriteLine($"Name: {Name} | Sex: {Sex} | Age: {Age} | Title: {Title}");

        }
    }
}
