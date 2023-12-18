using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public abstract class Person
    {
        public string name;
        public string l_name;
        public int age;
        public DateTime date_b;
        public int who; 

        public Person(string name, string l_name, DateTime date_b)
        {
            this.name = name;
            this.l_name = l_name;
            this.date_b = date_b;
        }

        public virtual void Print()
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nДата рождения: {2}\nВозраст: {3} лет", 
                name, l_name, date_b.ToString("D"), this.Age(date_b));
        }

        public int Age(DateTime date_b)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - date_b.Year;
            if (date_b > today.AddYears(-age)) age--;
            this.age = age;
            return this.age;
        }
    }
}
