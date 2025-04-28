using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IChatroomMediator 
    {
        void ShowMessage(User user, string message);
    }
}
