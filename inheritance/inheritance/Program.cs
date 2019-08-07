 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    /* Adding to constructers such as :base(parameters) */
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Mary", "Jane", "mj1", "MBlock");
            Console.WriteLine(t1.GetTeachDeets());
            
            Student s1 = new Student("", "", 0);
            Console.WriteLine("\nEnter first name: ");
            s1.Fname = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            s1.Lname = Console.ReadLine();
            Console.WriteLine("Enter student ID: ");
            s1.StudentId = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{s1.Fname} {s1.Lname}\n{s1.StudentId}");
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

    }
    class Student : Person
    {
        public int StudentId { get; set; }
        public Student(string _fname, string _lname, int _stdid)
        {
            Fname = _fname;
            Lname = _lname;
            StudentId = _stdid;
        }
        public string GetStdtDeets()
        {
            return $"\n{Fname} {Lname}\n{StudentId}";
        }
    }
    class Employee : Person
    {
        public string EmployeeId { get; set; }
    }
    class Teacher : Employee
    {
        public string Office { get; set; }
        public Teacher(string _fname, string _lname, string _empid, string _office)
        {
            Fname = _fname;
            Lname = _lname;
            EmployeeId = _empid;
            Office = _office;
        }
        public string GetTeachDeets()
        {
            return $"{Fname} {Lname}\n{EmployeeId}\n{Office}";
        }
    }
}
