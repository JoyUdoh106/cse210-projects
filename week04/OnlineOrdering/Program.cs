class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Order 1 ---");
        Address address1 = new Address("123 Maple St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "PROD-001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "PROD-002", 25.50, 1));
        order1.AddProduct(new Product("Keyboard", "PROD-003", 49.95, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}");
        Console.WriteLine("-----------------\n");

        Console.WriteLine("--- Order 2 ---");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "PROD-004", 39.00, 2));
        order2.AddProduct(new Product("Webcam", "PROD-005", 85.00, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");
        Console.WriteLine("-----------------\n");
    }
}