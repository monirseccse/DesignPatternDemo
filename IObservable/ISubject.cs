using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    internal interface ISubject
    {
        void Resgister(IObservable observable);
        void Remove(IObservable observable);
        void Notify(List<IObservable> observables);

    }
}
