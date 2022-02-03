using System;
using test_task_library;

namespace test_task
{
    class Program
    {
     /* static  public double Circle(double r)
        {
            double S;
            S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(S);
            return S;
        }
        static public double Triangle(double a, double b, double c)
        {
            double S, P,k,m;
            P = (a + b + c) / 2;
            S = Math.Sqrt(P * ((P - a) * (P - b) * (P - c)));
           m= Math.Pow(c, 2);
            k = Math.Pow(a, 2) +Math.Pow(b, 2);
            if (m==k)
            {
                Console.WriteLine($"Треугольник прямоугольный. Его площадь: {S}");
            }
            else
            {
                Console.WriteLine($"Площадь треугольника {S}");
            }
            
            return S;
        }*/
        static void Main(string[] args)
        {
            Test_task test_ = new Test_task();
            double r = Convert.ToDouble( Console.ReadLine());
            test_.Circle(r);
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            test_.Triangle(a, b, c);
        }
    }
}
