using PrimaryConstructorsDemo.Models;

class Program
{
    static void Main()
    {
        var product = new Product("Laptop", 59999.99m);
        Console.WriteLine(product.GetDetails());

        var customer = new Customer("Niraj", 30);
        customer.PrintInfo();
    }
}
