using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class GasContainer : Container,IHazardNotifier
{
    public int Pressure { get; set; }

    public GasContainer(double cargoWeight, int height, int selfWeight, int deep, int maxLoad,int pressure) : base(cargoWeight, height, selfWeight, deep, maxLoad)
    {
        this.Type = 'G';
        this.Name = "KON-" + Type + "-" + counter;
        Pressure = pressure;
    }

    public void SendNotify(string message)
    {
        Console.WriteLine(Name+" "+message);
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