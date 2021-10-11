using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota1
{
    class Get
    {
        public double Num()
        {
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch { return Num(); }
        }
    }
}
