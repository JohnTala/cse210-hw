class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return _street + "\n" + _city + ", " + _state + "\n" + _country;
    }
}