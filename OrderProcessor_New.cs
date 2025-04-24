using System;

public class OrderProcessor_New
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("Processing order using new system");
        // New implementation with improved features
        Console.WriteLine($"Order {order.OrderId} processed with new system, total: {order.TotalAmount} {OrderConfigurationManager.Instance.Currency}");
    }
} 