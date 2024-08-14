using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class RedLightState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
           trafficLight.State = new GreenLightState();
        }

        public void DisplayState()
        {
            Console.WriteLine("Red");
        }
    }
}
