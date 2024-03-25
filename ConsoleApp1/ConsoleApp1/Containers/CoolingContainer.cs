using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class CoolingContainer : Container , IHazardNotifier , PosibleProductsTemperature
{
    public PossibleProducts Product { get; set; }
    public double Temperature { get; set; }

    public CoolingContainer(double cargoWeight, int height, int selfWeight, int deep, int maxLoad, PossibleProducts product,double temperature) : base(cargoWeight, height, selfWeight, deep, maxLoad)
    {
        this.Temperature = temperature;
        this.Product = product;
        if (temperature != Containers.PosibleProductsTemperature.RequiredTemperature(product))
        {
            SendNotify(" Wrong Temperature for " + product); 
        }
        this.Type = 'C';
        Name = "KON-" + Type + "-" + Container.counter;
    }
    
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }

    public void SendNotify(string message)
    {
        Console.WriteLine(Name+" "+message);
    }
}