using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDesignPattern
{
    internal class MessageStrategy : IMessageStrategy
    {
        private readonly IEnumerable<IMessageService> _messageServices;

        public MessageStrategy(IEnumerable<IMessageService> notificationServices)
        {
            _messageServices = notificationServices ?? throw new ArgumentNullException(nameof(notificationServices));
        }

        public void Send(string message, string body, string provider)
        {
            string[] providers = provider.Split(';').Select(p => p).ToArray();
            this.Send(message, body, providers);
        }

        public void Send(string message, string body, IEnumerable<string> providers)
        {
            foreach (IMessageService messageService in _messageServices)
            {
                if (messageService.AppliesTo(providers))
                {
                    messageService.Send(message, body);
                }
            }
            return;
        }
    }
}
