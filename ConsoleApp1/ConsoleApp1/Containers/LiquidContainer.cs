using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container , IHazardNotifier
{
    public bool IsDangeraous { get; set; }

    public LiquidContainer(double cargoWeight, int height, int selfWeight, int deep, int maxLoad, bool isDangeraous) : base(cargoWeight, height, selfWeight, deep, maxLoad)
    {
        this.Type = 'L';
        Name = "KON-" + Type + "-" + Container.counter;
        IsDangeraous = isDangeraous;
    }
    
    public void Load(double cargoWeight, bool IsDangareous)
    {
        if (this.IsDangeraous && cargoWeight>0.5*this.CargoWeight)
        {
            SendNotify("You have dangerous load! You cannot load more than 50% of capacity");
        }else if (!IsDangareous && cargoWeight>0.9*this.CargoWeight)
        {
            SendNotify("You cannot load more than 90% of capacity");
        }
    }


    public void SendNotify(string message)
    {
        Console.WriteLine(message);
    }
    
}