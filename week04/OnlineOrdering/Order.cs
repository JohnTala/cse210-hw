class Order
{
    public List<Product> _products = new List<Product>();
    public Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            total += 5; // USA shipping
        }
        else
        {
            total += 35; // International shipping
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += "- " + product.GetLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetCustomerInfo();
    }
}
