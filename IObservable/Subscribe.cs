using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    internal class Subscribe : ISubscriber
    {
        public void Update(string news)
        {
            Console.WriteLine(news);
        }
    }
}
