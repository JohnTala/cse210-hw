class Product
{
    public string _name;
    public string _productId;
    public double _price;
    public int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetLabel()
    {
        return _name + " (ID: " + _productId + ")";
    }
}