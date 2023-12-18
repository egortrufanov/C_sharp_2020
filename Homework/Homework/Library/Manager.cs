using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Manager : Person, IEmployee
    {
        public string faculty;

        public int hours { get; set; }

        public Manager(string name, string l_name, DateTime date_b, 
            string faculty, int hours) : base(name, l_name, date_b)
        {
            this.faculty = faculty;
            this.hours = hours;
            this.Money(hours);
            this.who = 3;
        }

        public int Money(int hours)
        {
            int zp = hours * 3000;
            return zp;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Факультет: {0}\nЗарплата: {1}\n", 
                faculty,  this.Money(hours));
        }
    }
}
