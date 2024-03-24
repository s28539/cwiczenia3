// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Containers;

Container container = new Container(100,1000,100,100,1000);
LiquidContainer container2 = new LiquidContainer(100,1000,100,100,1000,true);
CoolingContainer container10 = new CoolingContainer(100, 200, 300, 100, 100,PossibleProducts.Bananas,13.4);
GasContainer container3 = new GasContainer(100,1000,100,100,1000,1000);


Console.WriteLine(container.Name);
Console.WriteLine(container2.Name);
Console.WriteLine(container3.Name);