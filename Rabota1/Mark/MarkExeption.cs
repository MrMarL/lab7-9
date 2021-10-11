using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mark
{
    public class MarkExeption : Exception
    {
        public MarkExeption(string message)
        : base(message)
        { }
    }
}
