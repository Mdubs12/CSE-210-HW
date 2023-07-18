public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        Console.WriteLine($"Total: ${Double.Round(totalCost, 2)}");

        if (_customer.LivesInUSA())
        {
            Console.WriteLine("Shipping: $5");
            totalCost += 5;
        }
        else
        {
            Console.WriteLine("Shipping: $35");
            totalCost += 35;
        }

        return Double.Round(totalCost, 2);
    }

    public string getPackagingLabel()
    {
        string packagingLabel = "";

        foreach (Product product in _products)
        {
            packagingLabel += $"({product.GetQuantity()}) {product.GetName()} - {product.GetId()}\n";
        }

        return packagingLabel;
    }

    public string getShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}