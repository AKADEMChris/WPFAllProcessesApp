using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAllProcessessApp
{
    internal class ProcessManager
    {
        public Process[] processes;

        public Process[] GetAll()
        {
            return processes = Process.GetProcesses();
        }
    }
}
