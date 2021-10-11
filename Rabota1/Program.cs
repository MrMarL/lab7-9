using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            A a3 = new A();
            B b1 = new B();
            C c1 = new C();

            b1.a = a1;
            c1.a = b1;
            c1.aa = a2;
            c1.aaa = a3;
        }
    }
}
