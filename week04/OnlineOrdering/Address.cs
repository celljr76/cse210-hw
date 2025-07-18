public class Address
{
    private string _streetAddress;
    private string _cityAddress;
    private string _stateOrProvidence;
    private int _zipCode;
    private string _country;

    public Address(string street, string city, string stateOrProvidence, string country, int zipCode)
    {
        _streetAddress = street;
        _cityAddress = city;
        _stateOrProvidence = stateOrProvidence;
        _country = country;
        _zipCode = zipCode;
    }
    public string DisplayAddress()
    {

        return $" {_streetAddress} \n {_cityAddress} {_stateOrProvidence} {_zipCode} \n {_country}";
    }
}