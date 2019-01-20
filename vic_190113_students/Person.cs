using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    class SortByAge:IComparer<Person> //Обобщенный интерфейс (будет работать с объектами типа Персон => не надо будет делать приведение типов
    {
        public int Compare (Person p1, Person p2)
        {
            if (p1.Age > p2.Age) return 1;
            else if (p1.Age < p2.Age) return -1;
            else return 0;
        }
    }
    class Person:IComparable
    {
        protected string name;
        protected string sex;
        protected double age;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Sex
        {
            set
            {
                sex = value;
            }
            get
            {
                return sex;
            }
        }
        public double Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        public Person()
        {
            //Console.WriteLine("ERROR - Empty person entered");
            Name = "ERROR";
            Sex = "ERROR";
            Age = -1;
        }

        public Person(string n, string s, double a)
        {
            Name = n;
            Sex = s;
            Age = a;
        }
        //virtual public void Show()
        //{
        //    Console.WriteLine($"Name: {Name} | Sex: {Sex} | Age: {Age}");
        //}

        public void FindSameSex(string neededSex)
        {
            if (Sex == neededSex)
            {
                Console.WriteLine("All persons with sex = " + neededSex + ": " + Name);
            }
        }

        public override string ToString()
        {
            string str = Name + ", " + Age.ToString() + ", ";
            if (Sex == "Man") str += "мужской";
            else str += "женский";
            return str;
        }
        virtual public void Show()
        {
            Console.WriteLine(ToString());
        }

        //Переопределяем иквал для сравнения
        public override bool Equals(object obj)
        {
            Person p = (Person)obj;
            if (this.Name == p.Name && this.Age == p.Age && this.Sex == p.Sex)
                return true;
            else
                return false;
        }

        static public bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
        static public bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }

        public int CompareTo(object obj)
        {
            Person p = (Person)obj;
            return String.Compare(this.Name, p.Name);
        }

    }
}
