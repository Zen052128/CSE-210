using System;
public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool InTheUSA()
    {
        return _address.InTheUSA();
    }
    public string Display()
    {
        return $"{_name}\n{_address.Display()}";
    }
}