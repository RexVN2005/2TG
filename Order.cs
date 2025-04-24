public class Order
{
    public int OrderId { get; set; }
    public List<IDigitalProduct> Products { get; set; } = new List<IDigitalProduct>();
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
} 