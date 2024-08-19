using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    internal interface INewsPaper
    {
        void Subscribe(ISubscriber subscriber);
        void UnSubscribe(ISubscriber subscriber);
        void Publish(string news);
        void Notify();
    }
}
