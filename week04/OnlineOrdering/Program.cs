using System;

class Program
{
    static void Main(string[] args)
    {
       // Order 1 - USA
        Address addr1 = new Address("100 Main St", "Phoenix", "AZ", "USA");
        Customer cust1 = new Customer("Henry Kalala", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Head Set", "PC123", 15.99, 2));
        order1.AddProduct(new Product("Charger", "CH456", 19.99, 1));

        // Order 2 - International
        Address addr2 = new Address("21 Marais road", "Claremont", "Cape Town", "SOUTH AFRICA");
        Customer cust2 = new Customer("Sbu Khumalo", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Monitor", "HP789", 79.99, 1));
        order2.AddProduct(new Product("Keyboard", "KB101", 39.99, 1));
        order2.AddProduct(new Product("Mouse", "MS202", 15.99, 1));

        // Display order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        // Display order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}