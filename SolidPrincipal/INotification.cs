using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipal
{
    internal interface INotification
    {
        Task  EmailNotify(string message);
        Task SMSNotify(string message);
    }
}
