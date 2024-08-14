using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDesignPattern
{
    internal interface IMessageStrategy
    {
        void Send(string message, string body, string provider);
        void Send(string message, string body, IEnumerable<string> providers);
    }
}
