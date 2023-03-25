public class Order
{
    private Customer customer;
    private Product[] products;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.GetPrice();
        }

        if (customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"\t{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";

        return shippingLabel;
    }
}