using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Student : Person
    {
        public string faculty;
        public string group;

        public Student(string name, string l_name, DateTime date_b, 
            string faculty, string group) : base (name, l_name, date_b)
        {
            this.faculty = faculty;
            this.group = group;
            this.who = 1;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Факультет: {0}\nГруппа: {1}\n", faculty, group);
        }
    }
}
