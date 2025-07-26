using System;

public class Customer
{
    private string _customerName;
    private Address _streetAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _streetAddress = address;
    }

    public bool InUSA()
    {
        return _streetAddress.InUSA();
    }

    public string GetName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _streetAddress.GetAddress();
    }
}