using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMarkLog log = MyMarkLog.I();
            QuadraticEquation qE = new QuadraticEquation();
            Get get = new Get();

            Console.WriteLine("Введите 3 параметра a, b и с");
            try
            {
                double a = get.Num(), b = get.Num(), c = get.Num();
                log.log("Введено уравнение:" + Environment.NewLine + a + "*X^2 +(" + b + ")*X + " + c + " = 0");
                log.log("Корни уравнения: " + String.Join(", ", qE.solve(a, b, c)));
            }
            catch (MarkExeption ex){ log.log(ex.Message); }

            log.write();

            Console.ReadKey();

            

        }
    }
}
