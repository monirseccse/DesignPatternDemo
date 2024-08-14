using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDesignPattern
{
    public class EmailMessageService : IMessageService
    {

        public void Send(string message, string recipient)
        {
            Console.WriteLine("Email send");
            
            return;
        }
        public bool AppliesTo(IEnumerable<string> providers)
        {
            return providers.Contains(ConstantResources.EmailNotification);
        }
    }
}
