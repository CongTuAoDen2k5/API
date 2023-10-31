namespace API.Request
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }
        public string ImageUrl { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int UnitId { get; set; }
    }
}
