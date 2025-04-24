using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digital Product Management System");
        Console.WriteLine("================================");
        
        // Singleton Pattern Demo
        var configManager = OrderConfigurationManager.Instance;
        Console.WriteLine($"Using currency: {configManager.Currency}");
        
        // Factory Pattern Demo
        Console.WriteLine("\nFactory Pattern Demo:");
        ProductCreator softwareCreator = new SoftwareProductCreator();
        var software = softwareCreator.CreateProduct();
        software.Name = "Visual Studio 2022";
        software.Price = 499.99m;
        
        ProductCreator cloudCreator = new CloudServiceProductCreator();
        var cloudService = cloudCreator.CreateProduct();
        cloudService.Name = "Azure Hosting";
        cloudService.Price = 99.99m;
        
        Console.WriteLine($"Created {software.Type}: {software.Name} - {software.Price}");
        Console.WriteLine($"Created {cloudService.Type}: {cloudService.Name} - {cloudService.Price}");
        
        // Create an order
        var order = new Order
        {
            OrderId = 1,
            OrderDate = DateTime.Now,
            Products = new List<IDigitalProduct> { software, cloudService },
            TotalAmount = software.Price + cloudService.Price
        };
        
        // Strangler Pattern Demo
        Console.WriteLine("\nStrangler Pattern Demo:");
        Console.WriteLine("Using old system:");
        var orderHandler = new OrderHandlerFacade(false);
        orderHandler.ProcessOrder(order);
        
        Console.WriteLine("\nUsing new system:");
        orderHandler = new OrderHandlerFacade(true);
        orderHandler.ProcessOrder(order);
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
} 