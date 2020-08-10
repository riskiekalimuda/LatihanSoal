using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoal.DELEGATE_TRIAL
{
    public delegate double Measure(double R);
    public class TestArrayDelegate
    {
        private const double PI = 3.14159;

        public double Diameter(double radius)
        {
            return (radius * 2);
        }
        public double Circumference(double radius)
        {
            return (Diameter(radius) * PI);
        }
        public double Area(double radius)
        {
            return (radius * radius * PI);
        }
        public void ProcessArrayDelegate(double R)
        {
            TestArrayDelegate arrDele = new TestArrayDelegate();
            Measure[] Calc = new Measure[3];
            Calc[0] = new Measure(arrDele.Diameter);
            double resultD = Calc[0](R);
            Calc[1] = new Measure(arrDele.Circumference);
            double resultC = Calc[1](R);
            Calc[2] = new Measure(arrDele.Area);
            double resultA = Calc[2](R);

            Console.WriteLine("Diameter: {0}", resultD);
            Console.WriteLine("Circum reference: {0}", resultC);
            Console.WriteLine("Area: {0}", resultA);
        }
    }
}
