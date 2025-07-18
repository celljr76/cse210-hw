using System;
class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Milk", 1, 3.99, 2);
        Product product2 = new Product("Cookies", 2, 5.99, 3);
        Product product3 = new Product("Choclate Bar", 3, 1.99, 5);
        Product product4 = new Product("Chips", 4, 5.00, 10);
        Product product5 = new Product("Chicken", 5, 7.99, 1);
        Product product6 = new Product("String Cheese", 6, 0.99, 5);
        Order order1 = new Order();
        Order order2 = new Order();
        Customer customer1 = new Customer();
        Customer customer2 = new Customer();
        customer1.SetName("Phillip Illguth");
        customer2.SetName("Bob Builder");
        customer1.SetAddress("53N HeartWood Street", "Fruit Heights", "Utah", "USA", 84037);
        customer2.SetAddress("528-530 Hornsey Road", "London", "London", "England", 193);
        double _totalProductCost1 = product1.TotalProductCost();
        double _totalProductCost2 = product2.TotalProductCost();
        double _totalProductCost3 = product3.TotalProductCost();
        double _totalProductCost4 = product4.TotalProductCost();
        double _totalProductCost5 = product5.TotalProductCost();
        double _totalProductCost6 = product6.TotalProductCost();
        double _order1TotalProductCost = _totalProductCost1 + _totalProductCost2 + _totalProductCost3;
        double _order2TotalProductCost = _totalProductCost4 + _totalProductCost5 + _totalProductCost6;
        string customer1Name = customer1.GetName();
        string customer1Address = customer1.GetAddress();
        string customer2Name = customer2.GetName();
        string customer2Address = customer2.GetAddress();
        order1.AddToCustomerOrder(product1.GetProduct());
        order1.AddToCustomerOrder(product2.GetProduct());
        order1.AddToCustomerOrder(product3.GetProduct());
        order2.AddToCustomerOrder(product4.GetProduct());
        order2.AddToCustomerOrder(product5.GetProduct());
        order2.AddToCustomerOrder(product6.GetProduct());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShipingLabel(customer1Name, customer1Address));
        Console.WriteLine(order1.GetOrderCost(customer1.CountryName(), _order1TotalProductCost));
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShipingLabel(customer2Name, customer2Address));
        Console.WriteLine(order2.GetOrderCost(customer2.CountryName(), _order2TotalProductCost));
    }
}