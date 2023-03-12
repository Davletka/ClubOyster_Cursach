using MongoDB.Driver;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace ClubOyster_Cursach.Data
{
    public class MongoDb
    {
        public static void AddDb(User user)
        {
            var client = new MongoClient();
            var dataBase = client.GetDatabase("ClubOyzer");
            var collection = dataBase.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static List<User> FindUsers()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();

            return list;
        }
    }
}
