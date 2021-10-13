using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota1
{
    class A
    {
        protected List<double> X;
        public List<double> Equation(double a, double b) {
            if (a == 0)
                return null;
            X = new List <double>();
            X.Add(-b / a);
            return X;
        }
    }
}
