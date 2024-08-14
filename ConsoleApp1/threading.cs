using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class threading
    {
        public void Print()
        {
            Thread thread = new Thread(a);
            thread.Start();
            Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.IsBackground);
            });
        }
        private void a()
        {

        }
    }
}
