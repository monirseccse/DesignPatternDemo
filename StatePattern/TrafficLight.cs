using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class TrafficLight
    {
        private ITrafficLightState _trafficLightState; 
        public ITrafficLightState State {
            get
            {
                return _trafficLightState;
            }
            set
            {
                _trafficLightState = value;
            }
        }

        public void Change()
        {
            _trafficLightState.Change(this);
        }
        public void Display()
        {
            _trafficLightState.DisplayState();
        }
    }
}
