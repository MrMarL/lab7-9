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

            log.log("LoL");
            log.log("LoLss");
            log.log("LoL13");

            log.write();


            //B b1 = new B();
            //Console.WriteLine("Введите 2 числа:");
            //List <double> x = b1.equation(get.Num(), get.Num());
            //Console.WriteLine(x.ToArray().Length==1?);
            Console.ReadKey();
        }
    }
}
