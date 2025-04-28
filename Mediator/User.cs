using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class User
    {
        private readonly IChatroomMediator _chatroom;
        public string Name { get; set; }
        public User(IChatroomMediator chatroom, string name)
        {
            _chatroom = chatroom;
            Name = name;
        }

        public void Send(string message)
        {
            _chatroom.ShowMessage(this, message);
        }
    }
}
