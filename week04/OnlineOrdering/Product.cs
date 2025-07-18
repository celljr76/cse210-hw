using System.Dynamic;

public class Product
{
    private string _name;
    private int _nameId;
    private double _productPrice;
    private int _quantity;
    public Product(string name, int nameId, double productPrice, int quantity)
    {
        _name = name;
        _nameId = nameId;
        _productPrice = productPrice;
        _quantity = quantity;

    }
    public string GetProduct()
    {
        return $"{_name} {_nameId}";
    }

    public double TotalProductCost()
    {
        double _total = _quantity * _productPrice;
        return _total;
    }
}