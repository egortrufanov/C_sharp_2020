using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            b2.ReturnSrok(); 
            Item it; 
            it = b2; 
            it.TakeItem(); 
            it.Return(); 
            it.Print(); 
            it = mag1; 
            it.TakeItem(); 
            it.Return(); 
            it.Print();
           

           
        }
    }
}
