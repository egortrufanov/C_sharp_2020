using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));

            Book b1 = new Book("Пушкин А. С.", "Капитанская", publ, 123, 2018, 201, true); ;
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            Book b3 = new Book("Лермонтов М. Ю.", "Мцыри", publ, 204, 2015, 108, true);

            Audit.RunAudit();
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Subs();
                        
            Magazine mag2 = new Magazine("О природе. ч2", 6, "Земля и мы", 2014, 10, true);
            Audit.StopAudit();
            mag2.Subs();


            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b1, b2, b3, mag1, mag2 });
            itlist.Sort();
            Console.WriteLine("\nСортировка по инвентарному номеру"); 
            foreach (Item x in itlist) 
            { 
                x.Print(); 
            }

        }
    }
}
