namespace TakeAway.CatalogApi.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string MainDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
