using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    class Person
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
        virtual public void Show()
        {
            Console.WriteLine($"Name: {Name} | Sex: {Sex} | Age: {Age}");
        }

        public void FindSameSex(string neededSex)
        {
            if (Sex == neededSex)
            {
                Console.WriteLine("All persons with sex = " + neededSex + ": " + Name);
            }
        }
    }
}
