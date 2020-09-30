using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace HW1
{
    abstract class Student
    {
        public string name;
        public string state;
        public Student(string nameOfPerson)
        {
            name = nameOfPerson;
            state = "";
        }
        abstract public void Study();

        public void Read()
        {
            state += "Read ";
        }
        public void Write()
        {
            state += "Write";
        }
        public void Relax()
        {
            state += "Relax";
        }
    }

    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            state = state + "good";
        }

        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            state = state + "bad";
        }

        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }

    class Group
    {
        public string groupname;
        public List<Student> A;
        public Group(string groupsname)
        {
            groupname = groupsname;
            A = new List<Student>();
        }
        public Group(string groupsname, List<Student> Students)
        {
            groupname = groupsname;
            A = Students;
        }
        public void AddStudent(Student st)
        {
            A.Add(st);
        }
        public void GetInfo()
        {
            Console.WriteLine(groupname);
            foreach (Student x in A)
            {
                Console.WriteLine(x.name + " "); 
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine(groupname);
            foreach (Student x in A)
            {
                Console.WriteLine(x.name + " - " + x.state);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GoodStudent st1 = new GoodStudent("Nataliia");
            BadStudent st2 = new BadStudent("Maks");
            GoodStudent st3 = new GoodStudent("Kseniia");
            List<Student> st = new List<Student> { st1, st2, st3 };
            Group first = new Group("K-24", st);

            BadStudent st4 = new BadStudent("Dmytro");
            BadStudent st5 = new BadStudent("Nikita");
            GoodStudent st6 = new GoodStudent("Maksymko");
            List<Student> stt = new List<Student> { st4, st5, st6 };
            Group second = new Group("K-24", stt);

            first.GetInfo();
            second.GetFullInfo();
        }
    }
}
