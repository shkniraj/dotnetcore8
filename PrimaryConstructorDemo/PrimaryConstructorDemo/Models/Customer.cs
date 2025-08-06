namespace PrimaryConstructorDemo.Models;

// Primary constructor without property exposure
public class Customer(string name, int age)
{
    public void PrintInfo()
    {
        Console.WriteLine($"Customer: {name}, Age: {age}");
    }
}
