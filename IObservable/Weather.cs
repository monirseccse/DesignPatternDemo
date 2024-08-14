using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservablePattern
{
    internal class Weather : ISubject
    {
        private readonly List<IObservable> _observable;
        private int _temparature;

        public Weather()
        {
            _observable = new();
        }

        public void Notify(List<IObservable> observables)
        {
            foreach (var observable in _observable)
            {
                observable.Update(_temparature);
            }
        }

        public void Remove(IObservable observable)
        {
            _observable.Remove(observable);
        }

        public void Resgister(IObservable observable)
        {
            _observable.Add(observable);
        }

        public void SetTemaparture(int  temaparture)
        { 
            _temparature = temaparture;
            Notify(_observable);
        }
    }
}
