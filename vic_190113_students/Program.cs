using System;
using System.Collections;
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
            Console.WriteLine("****************************************************");
            //Hashtable ht1 = new Hashtable();
            //for (int i=0; i<3;i++)
            //{
            //    Console.WriteLine("Enter name: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter age: ");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter gender: ");
            //    string gender = Console.ReadLine();
            //    //if (gender == "Man")
            //    Console.WriteLine("Enter course: ");
            //    int course = Convert.ToInt32(Console.ReadLine());

            //    Student s = new Student(name, gender, age, course, st2m);
            //    Person p = new Person(name, gender, age);
            //    ht1.Add(p, s);
            //}

            //Console.WriteLine("HT count: " + ht1.Count.ToString());
            //ICollection keys = ht1.Keys; //Коллекция ключей

            //foreach (Person p in keys)
            //{
            //    Console.WriteLine(ht1[p].ToString());
            //}
            Console.WriteLine("****************************************************");
            Hashtable ht2 = new Hashtable();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter gender: ");
                string gender = Console.ReadLine();
                //if (gender == "Man")
                Console.WriteLine("Enter course: ");
                int course = Convert.ToInt32(Console.ReadLine());

                Student s = new Student(name, gender, age, course, st2m);
                Person p = new Person(name, gender, age);
                ht2.Add(i+1, s);
            }
            Console.WriteLine("HT count: " + ht2.Count.ToString());
            ICollection keys2 = ht2.Keys; //Коллекция ключей
            Console.WriteLine("****");
            foreach (int i in keys2)
            {
                Console.WriteLine(ht2[i].ToString());
            }
            //Add one more element in ht2
            Student stIvanov = new Student("Ivanovvvvvvvvvv", "m", 22, 4, st3m);
            ht2.Add(5, stIvanov);
            //ht2[1] = new Student("Ivanovvvvvvvvvv", "m", 22, 4, st3m);
            Console.WriteLine("****");
            foreach (int i in keys2)
            {
                Console.WriteLine(ht2[i].ToString());
            }
            Console.WriteLine("****");
            Console.WriteLine("Check if element is in ht: ");
            if (ht2.ContainsValue(stIvanov))
                Console.WriteLine("Found");
            else
                Console.WriteLine("NOT found");

            Queue q1 = new Queue();



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
