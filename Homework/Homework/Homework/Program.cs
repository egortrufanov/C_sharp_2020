using System;
using System.Collections.Generic;
using System.Web;
using System.Xml.Serialization;
using Homework;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bd1 = new DateTime(2001, 10, 14);
            Student p1 = new Student("Егор", "Труфанов", bd1, "ИКТ", "K3122");
            p1.Print();

            DateTime bd2 = new DateTime(1965, 09, 10);
            DateTime st2 = new DateTime(1990, 10, 13);
            Teacher p2 = new Teacher("Александр", "Петров", bd2, "ИКТ", "Программирование", st2, 48);
            p2.Print();

            DateTime bd3 = new DateTime(1980, 07, 19);
            Manager p3 = new Manager("Алиса", "Кабанова", bd3, "БТИнС", 30);
            p3.Print();

            DateTime bd4 = new DateTime(1978, 01, 31);
            Admin p4 = new Admin("Виталий", "Сапко", bd4, "Лаборатория 1", 28);
            p4.Print();

            List<Person> pList = new List<Person>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            int signal = 1;
            try
            {
                while (signal == 1)
                {
                    Console.WriteLine("Желаете ли добавить сотрудника? Да(1)/Нет(0)");
                    char ch1 = char.Parse(Console.ReadLine());
                    switch (ch1)
                    {
                        case '1':
                            {
                                Console.Write("Имя: ");
                                string name = Console.ReadLine();
                                Console.Write("Фамилия: ");
                                string l_name = Console.ReadLine();
                                Console.Write("Дата рождения: ");
                                DateTime bd = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Кем он(а) является?\nСтудент(1), Преподаватель(2), Менеджер(3) или Администратор(4)");
                                char ch2 = char.Parse(Console.ReadLine());
                                switch (ch2)
                                {
                                    case '1':
                                        {
                                            Console.Write("Факультет: ");
                                            string faculty = Console.ReadLine();
                                            Console.Write("Группа: ");
                                            string group = Console.ReadLine();
                                            Student st = new Student(name, l_name, bd, faculty, group);
                                            Console.WriteLine("\nБыл добавлен студент:");
                                            pList.Add(st);
                                            st.Print();
                                        }
                                        break;
                                    case '2':
                                        {
                                            Console.Write("Факультет: ");
                                            string faculty = Console.ReadLine();
                                            Console.Write("Предмет: ");
                                            string subject = Console.ReadLine();
                                            Console.Write("Дата начала работы: ");
                                            DateTime start = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Сколько часов работает в неделю: ");
                                            int hours = int.Parse(Console.ReadLine());
                                            Teacher tc = new Teacher(name, l_name, bd, faculty, subject, start, hours);
                                            Console.WriteLine("\nБыл добавлен преподаватель:");
                                            pList.Add(tc);
                                            tc.Print();
                                        }
                                        break;
                                    case '3':
                                        {
                                            Console.Write("Факультет: ");
                                            string faculty = Console.ReadLine();
                                            Console.Write("Сколько часов работает в неделю: ");
                                            int hours = int.Parse(Console.ReadLine());
                                            Manager mn = new Manager(name, l_name, bd, faculty, hours);
                                            Console.WriteLine("\nБыл добавлен менеджер:");
                                            pList.Add(mn);
                                            mn.Print();
                                        }
                                        break;
                                    case '4':
                                        {
                                            Console.Write("Лаборатория: ");
                                            string lab = Console.ReadLine();
                                            Console.Write("Сколько часов работает в неделю: ");
                                            int hours = int.Parse(Console.ReadLine());
                                            Admin adm = new Admin(name, l_name, bd, lab, hours);
                                            Console.WriteLine("\nБыл добавлен администратор:");
                                            pList.Add(adm);
                                            adm.Print();
                                        }
                                        break;
                                    default:
                                        {
                                            Console.WriteLine("Вы ошиблись, поэтому начинаем заново!");
                                            break;
                                        }
                                }
                                break;
                            }
                        case '0':
                            {
                                signal = 0;
                            }
                            break;
                        default:
                            { 
                                Console.WriteLine("Неверно введено");
                                break;
                            }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Извините, но вы что-то напутали, а именно: {0}", e.Message);
            }

            Console.WriteLine("\nСписок сотрудников:");
            foreach (Person p in pList)
            {
                int ch = p.who;
                switch (ch)
                    {
                        case 1:
                            {
                                Console.WriteLine("Студент");
                                p.Print();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Преподаватель");
                                p.Print();
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Менеджер");
                                p.Print();
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Администратор");
                                p.Print();
                            }
                            break;
                    }
            }

            Console.WriteLine("Поиск по возрасту");
            Console.WriteLine("Введите минимальный возраст");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальный возраст");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("\nРезультаты поиска:\n");
            foreach (Person p in pList)
            {
                if ( p.Age(p.date_b) >= min && p.Age(p.date_b) <= max)
                {
                    p.Print();
                }
                    
            }
        }

    }
}

