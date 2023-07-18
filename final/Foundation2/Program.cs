using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Hunters Rd.", "Walla Walla", "Washington", "USA");
        Customer customer1 = new Customer("John", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Soda", "6TY21P", 2.50, 8));
        order1.AddProduct(new Product("Corn on the Cob", "QW58T6", 3.00, 10));
        order1.AddProduct(new Product("Ham Sandwich", "RT687U", 4.56, 7));

        Address address2 = new Address("648 Guerro St.", "Champerico", "Retalhuleu", "Guatemala");
        Customer customer2 = new Customer("Tio Jorge", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Nintendo Switch", "KL7J65", 350.25, 1));
        order2.AddProduct(new Product("Breath of the Wild", "HTN2JL", 70.59, 1));
        order2.AddProduct(new Product("Joycon Controller", "TPL879", 80, 2));

        Console.WriteLine("Order 1:\n");
        Console.WriteLine($"Packing Label:\n{order1.getPackagingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.getShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine();

        Console.WriteLine("Order 2:\n");
        Console.WriteLine($"Packing Label:\n{order2.getPackagingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.getShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
    }
}