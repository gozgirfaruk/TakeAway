using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TakeAway.CatalogApi.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string MainDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }



    }
}
