public class Customer
{
    private string _name;
    private string _customerAddress;  
    
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return $" {_name}";
    }
    public void SetAddress(string street, string city, string stateOrProvidence, string country, int zipcode)
    {
        Address address = new Address(street, city, stateOrProvidence, country, zipcode);
        _customerAddress = address.DisplayAddress();
    }
    public string GetAddress()
    {
        return _customerAddress;
    }

    public string GetCountry()
    {
        string[] _addressParts = _customerAddress.Split(" ");
        int index = _addressParts.Count() - 1;
        string country = _addressParts[index];
        return country;
    }
    
    public bool CountryName()
    {
        bool _countryName = false;
        if (GetCountry() == "USA")
        {
            _countryName = true;
        }
        else
        {
            _countryName = false;
        }
        return _countryName;
    }

}