using ConsoleApp1.Exceptions;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Containers;

public class Container : IContainer
{
    public static int counter = 0;
    public double CargoWeight { get; set; }
    public int Height { get; set; }
    public int SelfWeight { get; set; }
    public int Deep { get; set; }
    public char Type { get; set; }
    public int MaxLoad { get; set; }
    public String Name { get; set; }

    public Container(double cargoWeight,int height,int selfWeight, int deep, char type,int maxLoad)
    {
        CargoWeight = cargoWeight;
        Height = height;
        SelfWeight = selfWeight;
        Deep = deep;
        Type = type;
        MaxLoad = maxLoad;
        Name = "KON-" + Type + "-" + counter;
        counter++;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        Console.WriteLine("Container");
        CargoWeight = cargoWeight;
        // throw new OverfillException();
    }
}
