using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;
        //Создание экземпляра
        public void SetTriangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        //Вывод длин сторон
        public override string ToString()
        { 
            string dlina = String.Format("Длины сторон: {0}, {1} и {2}", A, B, C); 
            return dlina; 
        }
        public void Length() 
        { 
            Console.WriteLine(this); 
        }
        //Расчет периметра
        public void Perimetr()
        {
            double P = A + B + C;
            Console.WriteLine("Периметр треугольника: {0}", P);
        }      
        //Расчет площади
        public void Square()
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine("Площадь треугольника: {0}", S);
        }
    }
}
