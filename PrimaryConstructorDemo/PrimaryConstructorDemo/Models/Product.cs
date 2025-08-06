namespace PrimaryConstructorDemo.Models;

// Primary constructor with public property exposure
public class Product(string name, decimal price)
{
    public string Name => name;
    public decimal Price => price;

    public string GetDetails() => $"{Name} costs ₹{Price}";
}
