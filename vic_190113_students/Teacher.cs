using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    class Teacher:Employee
    {
        protected string department;
        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        //public Teacher() : base() //Вызываем конструктор базового класса
        //{

        //}
        //public Teacher(string n, string s, double a, string t) : base(n, s, a, t) //Вызываем конструктор базового класса
        //{
        //    Department = "ERROR";
        //}
        public Teacher(Employee empl, string d)
        {
            Name = empl.Name;
            Sex = empl.Sex;
            Age = empl.Age;
            Title = empl.Title;
            Department = d;
        }

        override public void Show()
        {

            Console.WriteLine($"Name: {Name} | Sex: {Sex} | Age: {Age} | Title: {Title} | Dept: {Department}");

        }
    }
}
