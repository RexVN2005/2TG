public class SoftwareProduct : IDigitalProduct
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Type => "Software";
} 