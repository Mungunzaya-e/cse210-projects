using System;
using System.Text;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public int GetShippingCost()
    {
        bool inUSA = _customer.InUSA();

        if (inUSA == true)
        {
            return 5;
        }

        return 35;
    }

    public void AddProductToList(Product product)
    {
        _productList.Add(product);
    }

    public string GetTotalCost()
    {
        double productTotal = 0;
        foreach (Product product in _productList)
        {
            double productCost = product.GetTotalCost();
            productTotal += productCost;
        }
        productTotal += GetShippingCost();
        return productTotal.ToString("F2");
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (Product product in _productList)
        {
            label.AppendLine($"\tProduct: {product.GetName()} (ID: {product.GetID()})");
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n\t{_customer.GetAddress()}";
    }
}