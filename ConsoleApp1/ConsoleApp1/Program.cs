// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Containers;

LiquidContainer liquidContainer = new LiquidContainer(200,1,1,1,1000,false);
// liquidContainer.Load(701);
// Console.WriteLine(liquidContainer.CargoWeight);

GasContainer gasContainer = new GasContainer(100,1,1,1,1000,1000);
gasContainer.Unload();
Console.WriteLine(gasContainer.CargoWeight);
gasContainer.Load(10000);