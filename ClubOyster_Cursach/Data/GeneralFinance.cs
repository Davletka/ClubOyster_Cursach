using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ClubOyster_Cursach.Data
{
    public class GeneralFinance
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public float Balance { get; set; }

        public float Credit { get; set; }

        public List<Products>? Products { get; set; }

        public List<Equipment>? Equipment { get; set; }

    }
}
