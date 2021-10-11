using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota1
{
    class B:A
    {
        public List<Double> Equation(double a, double b, double c)
        {
            if (a == 0)
                return Equation(b, c);

            X = new List <double>();

            double d = Deck(a,b,c);
            if (d > 0) // Условие при дискриминанте больше нуля
            {
                X.Add((-b + Math.Sqrt(d)) / (2 * a));
                X.Add((-b - Math.Sqrt(d)) / (2 * a));
            }
            if (d == 0) // Условие для дискриминанта равного нулю
                X.Add(-(b / (2 * a)));

            return X;
        }

        protected double Deck(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
