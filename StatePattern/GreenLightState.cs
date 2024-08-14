using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class GreenLightState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.State = new RedLightState();
        }

        public void DisplayState()
        {
            Console.WriteLine("Green");
        }
    }
}
