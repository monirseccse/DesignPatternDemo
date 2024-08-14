namespace StatePattern
{
    internal interface ITrafficLightState
    {
        void Change(TrafficLight trafficLight);
        void DisplayState();
    }
}
