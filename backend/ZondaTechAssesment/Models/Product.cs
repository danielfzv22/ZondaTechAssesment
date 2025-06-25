namespace ZondaTechAssesment.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
