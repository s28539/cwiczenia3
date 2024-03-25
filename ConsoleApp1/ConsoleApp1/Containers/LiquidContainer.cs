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
    
    public override void Load(double cargoWeight)
    {
        if (this.IsDangeraous && ( (CargoWeight + cargoWeight) >(0.5*this.MaxLoad) ) )
        {
            SendNotify("You have dangerous load! You cannot load more than 50% of capacity");
        }else if (!IsDangeraous && ( (CargoWeight + cargoWeight) >(0.9*this.MaxLoad) ) )
        {
            SendNotify("You cannot load more than 90% of capacity");
        }else
        {
            CargoWeight = CargoWeight + cargoWeight;
        }
    }


    public void SendNotify(string message)
    {
        Console.WriteLine(Name+" "+message);
    }
    
}