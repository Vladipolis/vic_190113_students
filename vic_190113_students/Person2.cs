using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    //enum Gender { man, woman };
    class Person2
    {
        public enum Gender { man, woman };
        protected string name2;
        public string Name2 { set; get; }
        protected int age2;
        public int Age2
        {
            get { return age2; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Wrong age");
                    age2 = 0;
                }
                else
                    age2 = value;
            }
        }
        public Gender gender { get; set; }
    }
}
