using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark
{
    class Equation
    {
        protected List<double> X;
        public List<double> solve(double a, double b) {
            if (a == 0)
                throw new MarkExeption("Определено, что такое уравнение не существует");;
            MyMarkLog.I().log("Определено, что это линейное уравнение");
            X = new List<double>();
            X.Add(-b / a);
            return X;
        }
    }
}
