using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace ClubOyster_Cursach.Data
{
    public class UserService
    {
        public User? user { get; set; }

        public User? Get()
        {
            return user;
        }

        public User Set(User mem)
        {
            this.user = mem;
            return user;
        }
    }
}
