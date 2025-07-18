using System.Runtime.InteropServices;

public class Order
{
    private List<string> _customerOrder = new List<string>();

    

    public void AddToCustomerOrder(string order)
    {
        _customerOrder.Add(order);
    }

    public string GetPackingLabel()
    {
         string _text = "";
        foreach (string i in _customerOrder)
        {
            _text += i + " ";
        }
        return _text;
    }
    public string GetShipingLabel(string name,string address)
    {
        return $"{name}\n{address}";
    }
    public double GetOrderCost(bool countryName,double totalOrderCost)
    {
        double _shippingCost = 0.00;
        if (countryName == true)
        {
            _shippingCost = 5.00;
        }
        else
        {
            _shippingCost = 35.00;
        }
        
        return _shippingCost  + totalOrderCost;
    }
}
