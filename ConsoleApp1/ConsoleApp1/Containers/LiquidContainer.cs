﻿namespace ConsoleApp1.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight) : base(cargoWeight)
    {
    }
    
    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        Console.WriteLine("LiquidContainer");
    }
}