using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vic_190113_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Show();
            Person p2 = new Person("Ivanov Ivan Ivanovich", "Man", 88);
            p2.Show();
            Person p3 = new Person("Petrov", "Man", 77);
            p3.Show();

            Employee e1 = new Employee();
            //e1.Show();
            Employee e2 = new Employee(p2, "NachKaf");
            e2.Show();

            //Teacher t1 = new Teacher();
            //t1.Show();
            Teacher t2 = new Teacher(e2, "ProstoPrepod");
            t2.Show();


            Console.ReadLine();
                
        }
    }
}
