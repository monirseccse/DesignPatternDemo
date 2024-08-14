using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    internal class Observable : IObservable
    {
        public void Update(int temparature)
        {
            Console.WriteLine($"current temparature is {temparature}"); 
        }
    }
}
