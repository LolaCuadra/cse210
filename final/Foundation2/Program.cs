using System;

public class Program
{
    public static void Main()
    {
        Product product1 = new Product("iPhone", 1, 100.00M, 1);
        Product product2 = new Product("iPad", 2, 20.00M, 1);
        Product product3 = new Product("Macbook", 3, 15.00M, 1);

        Address address1 = new Address("13 Burritt", "Norwalk", "CT", "USA");
        Customer customer1 = new Customer("Lola Cuadra", address1);

        Address address2 = new Address("Guamilito", "Cortes", "San Pedro Sula", "Honduras");
        Customer customer2 = new Customer("Josue Molina", address2);

        Order order1 = new Order(customer1, new Product[] { product1, product2, product3 });
        Order order2 = new Order(customer2, new Product[] { product2 });

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
        Console.WriteLine();
    }
}
