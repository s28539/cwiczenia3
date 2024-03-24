using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class GasContainer : Container,IHazardNotifier
{
    public int Pressure { get; set; }

    public GasContainer(double cargoWeight, int height, int selfWeight, int deep, char type, int maxLoad,int pressure) : base(cargoWeight, height, selfWeight, deep, type, maxLoad)
    {
        Pressure = pressure;
    }

    public void SendNotify(string message)
    {
        Console.WriteLine(message);
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        
    }

    public override void Unload()
    {
        CargoWeight = CargoWeight * 0.05;
    }
}