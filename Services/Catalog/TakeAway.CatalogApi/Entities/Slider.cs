using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAway.CatalogApi.Entities
{
    public class Slider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SliderID { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    
    }
}
