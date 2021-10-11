using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark
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
