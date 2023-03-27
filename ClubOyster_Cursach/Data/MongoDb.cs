using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
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

        public static void ReplaceByName(User member, string login)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Login == member.Login, member);
        }

        public static void FilesUpload(IBrowserFile ibrows, string path)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            IGridFSBucket gridFs = new GridFSBucket(database);

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFs.UploadFromStreamAsync(ibrows.Name, fs);
            }
        }
        public static void FilesDownLoad()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("ClubOyzer");
            IGridFSBucket gridFs = new GridFSBucket(database);
        }
    }
}
