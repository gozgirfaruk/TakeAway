using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TakeAway.CatalogApi.Entities
{
    public class DailyDiscount
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DailyDiscountID { get; set; }
        public string MainTitle { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
