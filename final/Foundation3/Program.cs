using System;

class Program

{
    static void Main(string[] args)
     // Create some test data
    {
        Address address = new Address("143 Main St", "Beachtown", "CA", "USA");
        Customer customer = new Customer("Joshua Banks", address);

        Product product1 = new Product("Widget", 1, 2.99, 2);
        Product product2 = new Product("Gizmo", 2, 1.99, 3);
        Product[] products = { product1, product2 };

        Order order = new Order(customer, products);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
    }
}