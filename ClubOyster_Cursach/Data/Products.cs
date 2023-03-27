using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ClubOyster_Cursach.Data
{
    public class Products
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string? Name { get; set; }

        public string? Category { get; set; }

        public int Count { get; set; }

        public float? Price { get; set; }
    }
}
