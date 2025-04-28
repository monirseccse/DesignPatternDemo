using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Chatroom : IChatroomMediator
    {
        public void ShowMessage(User user, string message)
        {
            Console.WriteLine($"{user.Name} is saying {message}");
        }
    }
}
