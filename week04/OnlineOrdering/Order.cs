using System;
using System.Diagnostics.CodeAnalysis;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double TotalCost()
    {
        double sum = 0;
        foreach (Product product in _products)
        {
            sum += product.TotalPrice();
        }
        if (_customer.InTheUSA() == true)
        {
            sum += 5;
        }
        else
        {
            sum += 35;
        }
        return sum;
    }
    public string PackingLabel()
    {
        string label = " ";
        foreach (Product product in _products)
        {
            label += $"{product.DisplayName()}: {product.DisplayID()}\n";
        }
        return label;
    }
    public string ShipppingLabel()
    {
        return $"{_customer.Display()}";
    }
}