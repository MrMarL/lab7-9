using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Mark
{
    class MyMarkLog : LogAbstract, LogInterface
    {
        private static MyMarkLog Single = null;

        List<string> logs = new List<string>();
        public static MyMarkLog I()
        {
            return Single = Single == null ? new MyMarkLog() : Single;
        }


        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}
