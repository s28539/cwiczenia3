namespace ConsoleApp1.Containers;

public enum PossibleProducts
{
    Bananas,
    Chocolate,
    Fish,
    Meat,
    IceCream,
    FrozenPizza,
    Cheese,
    Sausages,
    Butter,
    Eggs
    
}

public interface PosibleProductsTemperature
{
    static private Dictionary<PossibleProducts, double> temperatures = new Dictionary<PossibleProducts, double>()
    {
        { PossibleProducts.Bananas, 13.3 },
        { PossibleProducts.Chocolate, 18 },
        { PossibleProducts.Fish, 2 },
        { PossibleProducts.IceCream, -18 },
        { PossibleProducts.FrozenPizza, -30 },
        { PossibleProducts.Cheese, 7.2 },
        { PossibleProducts.Sausages, 5 },
        { PossibleProducts.Butter, 20.5 },
        { PossibleProducts.Eggs, 19 }
    };

    static public double RequiredTemperature(PossibleProducts product)
    {
        return temperatures[product];
    }
}