using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;

    public Product(string name, string id, double price)
    {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _productQuantity = 1;
    }

    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public double GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetID()
    {
        return _productID;
    }
}