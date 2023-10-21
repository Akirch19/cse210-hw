using System;

class Program
{
    static void Main(string[] args)
    // got produce prices from Safeway.com 
   
    {
        //order 1 
        Address address1 = new Address ("1212 false ave.", "Sahuarita", "AZ", "USA");
        Customer customer1 = new Customer("Austin Kirchner", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Banana", "4011", 0.36, 4);
        Product order1Product2 = new Product("Broccoli Crowns", "3082", 2.62, 3);
        Product order1Product3 = new Product("Avocado", "4225", 1.00, 6);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);

        //order 2
        Address address2 = new Address ("997 fake lane", "Oxford", "OX1", "UK");
        Customer customer2 = new Customer("Casey Kirchner", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Star Fruit", "4256", 3.99, 2);
        Product order2Product2 = new Product("Guava", "4299", 3.99, 1);
        Product order2Product3 = new Product("Sweet Onion", "3286", 1.49, 4);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();

        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
    }
}