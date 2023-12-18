using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Homework
{
    public class Teacher : Person, IEmployee
    {
        public string faculty;
        public string subject;
        public DateTime start;
        public int work;
        public int hours { get; set; }
         

        public Teacher(string name, string l_name, DateTime date_b, string faculty, 
            string subject, DateTime start, int hours) : base(name, l_name, date_b)
        {
            this.faculty = faculty;
            this.subject = subject;
            this.start = start;
            this.hours = hours;
            this.Work(start);
            this.Money(hours);
            this.who = 2;
        }

        public int Work(DateTime start)
        {
            DateTime today = DateTime.Today;
            int work = today.Year - start.Year;
            if (start > today.AddYears(-work)) work--;
            this.work = work;
            return this.work;
        }

        public int Money(int hours)
        {
            int zp = hours*2000;
            return zp;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Факультет: {0}\nПредмет: {1}\nСтаж: {2} лет\nЗарплата: {3}\n", 
                faculty, subject, this.Work(start), this.Money(hours));
        }

        

    }
    
}
