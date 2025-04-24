using System;

public sealed class OrderConfigurationManager
{
    private static readonly Lazy<OrderConfigurationManager> _instance = 
        new Lazy<OrderConfigurationManager>(() => new OrderConfigurationManager());
    
    public static OrderConfigurationManager Instance => _instance.Value;
    public string Currency { get; set; } = "USD";
    
    private OrderConfigurationManager() { }
} 