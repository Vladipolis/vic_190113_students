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
            Console.WriteLine("------------");
            Person p2 = new Person("Ivanov Ivan Ivanovich", "Man", 88);
            p2.Show();
            Console.WriteLine("------------");
            Person p3 = new Person("Petrov", "Zh", 77);
            p3.Show();
            Person p4 = new Person("Petrov", "Zh", 77);
            p4.Show();
            Console.WriteLine("------------");
            Employee e1 = new Employee();
            e1.Show();
            Console.WriteLine("------------");
            Employee e2 = new Employee(p2, "NachKaf");
            e2.Show();
            Console.WriteLine("------------");
            Employee e3 = new Employee(p3, "NachKaf");
            e3.Show();
            Console.WriteLine("------------");
            Teacher t1 = new Teacher();
            t1.Show();
            Console.WriteLine("------------");
            Teacher t2 = new Teacher(e2, "ProstoPrepod", "Kaf1");
            t2.Show();
            Console.WriteLine("------------");
            Teacher t3 = new Teacher("Uchitelev", "Man", 40, "Prepod vyssh cat", "Kaf1");
            t3.Show();
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            int[] st1m = { 1, 2, 3, 4, 5, 6 };
            Student st1 = new Student("Zahar Zaharov", "Male", 18, 1, st1m);
            st1.Show();
            Console.WriteLine("------------");
            int[] st2m = { 5, 5, 5 };
            Student st2 = new Student("Prilep Prilepin", "Zh", 20, 3, st2m);
            st2.Show();
            int[] st3m = { 1, 2, 3, 1 };
            Student st3 = new Student("Studentova", "Zh", 20, 1, st3m);
            st3.Show();
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            //ПРоверка сравнения
            Console.WriteLine(p3.Equals(p4));
            Console.WriteLine(p3==p4);
            Console.WriteLine("***************************************************");
            
            Person[] perArr = { p1, p2, p3, e1, e2, t1, t2, t3, st1, st2, st3 };
            foreach (Person per in perArr)
            {
                per.Show();
            }
            Console.WriteLine("***********************SORT by NAME:****************************");
            Array.Sort(perArr);
            foreach (Person per in perArr)
            {
                per.Show();
            }
            Console.WriteLine("***********************SORT by AGE:****************************");
            Array.Sort(perArr, new SortByAge());
            foreach (Person per in perArr)
            {
                per.Show();
            }
            Console.WriteLine("***************************************************");
            //Проверка работы со средней оценкой для конкретного студента
            AverageMark(perArr, st1);
            foreach (Person per in perArr)
            {
                //per.Show();
                per.FindSameSex("Zh");

            }
            //Count student on course
            foreach (Person per in perArr)
            {

                if (per is Student)
                {
                    Student stu = per as Student;
                    if (stu.Course == 1)
                    {
                        Console.WriteLine("FOUND COURSE!");
                    }
                }
            }

            //Find teachers from the same kafs
            foreach (Person per in perArr)
            {
                if (per is Teacher)
                {
                    Teacher tea = per as Teacher;
                    tea.FindPrepods("Kaf1");
                }
            }
            //Count average student mark
            foreach (Person per in perArr)
            {

                if (per is Student)
                {
                    Student stu = per as Student;
                    stu.CountAverageMark();
                }
            }

            Console.WriteLine($"Количество студентов-отличников= {CountExcellentsStudents(perArr)}");


            Console.ReadLine();

        }
        static int StudentsCount(Person[] mas, int course)
        {
            int count = 0;
            foreach (Person p in mas)
                if (p is Student)
                    if (((Student)p).Course == course)
                        count++;
            return count;
        }

        static void AverageMark(Person[] mas, Student s)
        {
            foreach (Person p in mas)
            {
                if (p is Student && p == s)
                    s.CountAverageMark();
            }

        }

        //Сколько студентов сдало на отлично //ToDO НалРеференс от ререписывания == и != в Персон
        //Решение: закомментировать перегрузки == и !=  и использовать Иквал
        static int CountExcellentsStudents(Person[] mas)
        {
            int count = 0;
            foreach (Person p in mas)
            {
                if (p is Student)
                {
                    if (p is Student)
                    {
                        Student s = p as Student;
                        if (s.IsExcellentStudent()) count++;
                        //if (s != null && s.IsExcellentStudent()) count++;
                    }
                }
            }
            return count;
        }
    }
}
