using System;

class Program

{
    static void Main(string[] args)
    {
    Address address = new Address ("143 Gordon Place", "Beachtown", "CA", "USA");
    Customer customer = new Customer ("Beverly Smith", address);
    Product product1 = new Product ("Nature's Made Fish Oil", 0016782, 25, 1 );
    Product product2 = new Product ("Nature's Made Collagen Gummy", 0013456, 25, 2);
    Product [] products = {product1, product2};
    Order order = new Order (customer, products);


    Address address1 = new Address ("14 Scarborough St", "Toronto", "ON", "CANADA");
    Customer customer1 = new Customer ("Charles Parker", address1);
    Product product3 = new Product ("Nature's Made Liver Detox 60 Cap", 0016782, (float)25.50, 1 );
    Product product4 = new Product ("Kirkland Vitamin D 2000 IU", 0013456, 25, 2);
    Product [] products1 = {product3, product4};
    Order order1 = new Order (customer1, products1);


    Console.WriteLine ();
    Console.WriteLine("PACKING LABEL:\n");
    Console.WriteLine ("PRODUCTS: \n");
    Console.WriteLine($"{order.GetPackingLabel()}");
    Console.WriteLine ($"Total Cost : ${order.GetTotalCost():F2}");
    Console.WriteLine ();
    Console.WriteLine("SHIPPING LABEL: \n");
    Console.WriteLine(order.GetShippingLabel());
    Console.WriteLine ();

    Console.WriteLine ("===========================================\n");
    Console.WriteLine ();
    Console.WriteLine("PACKING LABEL:\n");
    Console.WriteLine ("PRODUCTS: \n");
    Console.WriteLine($"{order1.GetPackingLabel()}");
    Console.WriteLine ($"Total Cost : ${order1.GetTotalCost():F2}");
    Console.WriteLine ();
    Console.WriteLine("SHIPPING LABEL: \n");
    Console.WriteLine(order1.GetShippingLabel());
    Console.WriteLine ();

    }
}