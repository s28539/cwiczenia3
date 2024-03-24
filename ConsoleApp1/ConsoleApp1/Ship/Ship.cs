using ConsoleApp1.Containers;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Ship;

public class Ship : IHazardNotifier
{
    private static int ShipId = 0;
    private List<Container> Containers { get; }
    private int Speed { get; set; }
    private int ContainerCapacity { get; set; }
    private int MaxLoad { get; set; }
    private double currentLoad { get; set; }
    private string ShipName { get; set; }

    public Ship( int speed, int containerCapacity, int maxLoad)
    {
        ShipId = ShipId +1;
        this.Containers = new List<Container>();
        this.Speed = speed;
        this.ContainerCapacity = containerCapacity;
        this.MaxLoad = maxLoad;
        this.currentLoad = 0;
        ShipName = "Ship" + ShipId;
    }

    public void Load(Container container)
    {
        if ((currentLoad + container.CargoWeight) <= MaxLoad && 
            (Containers.Count + 1 <= ContainerCapacity))
        {
            Containers.Add(container);
            currentLoad = currentLoad + container.CargoWeight;
        }
        else
        {
            SendNotify("Cannot add containers to ship");
        }
    }

    public void Load(List<Container> containersList)
    {
        double ContainerListWeight = 0;
        foreach (var container in containersList)
        {
            ContainerListWeight = ContainerListWeight + container.CargoWeight;
        }

        if ((currentLoad + ContainerListWeight) <= MaxLoad &&
            (Containers.Count + containersList.Count) <= ContainerCapacity)
        {
            foreach (var container in containersList)
            {
                Containers.Add(container);
            }
        }
        else
        {
            SendNotify("Cannot add containers to ship");
        }
    }

    public void SendNotify(string message)
    {
        Console.WriteLine(ShipName +" "+message);
}
}