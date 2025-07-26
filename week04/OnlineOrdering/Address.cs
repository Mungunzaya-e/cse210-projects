using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address()
    {
    }

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool InUSA()
    {
        if (_country == "United States")
        {
            return true;
        }

        return false;
    }

    public string GetAddress()
    {
        return $"{_street}\n\t{_city}, {_stateOrProvince} \n\t{_country}";
    }
}