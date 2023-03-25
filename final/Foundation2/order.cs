public class Order
{
    private Customer _customer;
    private Product [] _products;
    
    public Order (Customer customer, Product [] products)

    {
        _customer = customer;
        _products = products;
    }

    public float GetTotalCost ()
    {
        float totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetPrice ();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel ()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
    return packingLabel;
    }

    public string GetShippingLabel ()

    {
        string shippingLabel = $" \t {_customer.GetName()} \n \t {_customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }
}