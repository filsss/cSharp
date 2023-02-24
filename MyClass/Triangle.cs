using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Triangle
    {
        private double a, b ,c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void SideShow()
        {
            Console.WriteLine("\n Сторона 1 {0} \n Сторона 2 {1} \n Сторона 3 {2}" ,a,b,c);

        }
        public void Perimetr()
        {
            Console.WriteLine("\nПрериметр треугольника равен {0}", a + b + c);
        }
        public void Area() 
        {
            double p = (a + b + c) / 2;
            double S = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
            Console.WriteLine("Площадь треугольника равна {0}", S );
        }
        public void Check()
        {
            bool checkTriangle = false;
            if ((a + b > c) & (a + c > b) & (b + c > a))
            {
                checkTriangle = true;
            }
            else
            { 
                checkTriangle = false;
            }
            Console.WriteLine("Результат проверки {0}", checkTriangle);
        }
    }
}
