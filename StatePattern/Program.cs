using StatePattern;

TrafficLight traffic = new TrafficLight();
traffic.State = new RedLightState();
while (true)
{
    traffic.Display();
    traffic.Change();
}