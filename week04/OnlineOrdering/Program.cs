using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
    
    Address address1 = new Address("123 Disney Way", "Orlando", "FL", "USA");
    
    Customer customer1 = new Customer("John Doe", address1);

    Product p1_1 = new Product("Wireless Mouse", "M102", 25.99, 2);  
    Product p1_2 = new Product("Mechanical Keyboard", "K552", 45.50, 1); 
    Product p1_3 = new Product("HDMI Cable 6ft", "C009", 8.25, 3);      

    Order order1 = new Order(customer1);
    order1.AddProduct(p1_1);
    order1.AddProduct(p1_2);
    order1.AddProduct(p1_3);

    Address address2 = new Address("456 Sakura Lane", "Shibuya", "Tokyo", "Japan");

    Customer customer2 = new Customer("Yuki Tanaka", address2);

    Product p2_1 = new Product("Noise Cancelling Headphones", "H900", 120.00, 1); 
    Product p2_2 = new Product("USB-C Fast Charger", "W220", 15.75, 2);           

    Order order2 = new Order(customer2);
    order2.AddProduct(p2_1);
    order2.AddProduct(p2_2);

    List<Order> orders = new List<Order>();
    orders.Add(order1);
    orders.Add(order2);

    foreach (Order item in orders)
        {
            Console.WriteLine(item.ShipppingLabel());
            Console.WriteLine(item.PackingLabel());
            Console.WriteLine($"Total Cost: {item.TotalCost()}");
            Console.WriteLine();
        }
    }
}