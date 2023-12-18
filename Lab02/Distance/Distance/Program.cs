using System;

namespace Distance
{
    public struct Distance
    {
        public int foot;
        public int inch;
        public Distance (int foot, int inch)
        {
            this.foot = foot;
            this.inch = inch;
        }
        public static Distance Add(Distance a, Distance b)
        {
            Distance c;
            c.foot = a.foot + b.foot;
            c.inch = a.inch + b.inch;
            c.foot += c.inch / 12;
            c.inch %= 12;
            return c;
        }
        public void Show()
        {
            Console.WriteLine("{0} '- {1}\"", this.foot, this.inch);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения для первых двух длин");
            int afoot = int.Parse(Console.ReadLine());
            int ainch = int.Parse(Console.ReadLine());
            int bfoot = int.Parse(Console.ReadLine());
            int binch = int.Parse(Console.ReadLine());
            Distance a = new Distance(afoot, ainch);
            Distance b = new Distance(bfoot, binch);
            Distance c;
            c = Distance.Add(a, b);
            a.Show();
            b.Show();
            c.Show();
        }
    }
}
