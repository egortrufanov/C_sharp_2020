using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Admin : Person, IEmployee
    {
        public string lab;

        public int hours { get; set; }


        public Admin(string name, string l_name, DateTime date_b, 
            string lab, int hours) : base(name, l_name, date_b)
        {
            this.lab = lab;
            this.hours = hours;
            this.Money(hours);
            this.who = 4;
        }

        public int Money(int hours)
        {
            int zp = hours * 2500;
            return zp;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Лаборатория: {0}\nЗарплата: {1}\n", 
                lab, this.Money(hours));
        }
    }
    
}
