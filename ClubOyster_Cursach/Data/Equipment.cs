using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;

namespace ClubOyster_Cursach.Data
{
    public class Equipment
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string? Name { get; set; }    

        public string? State { get; set; }


    }
}
