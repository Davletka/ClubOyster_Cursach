using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ClubOyster_Cursach.Data
{
    public class User
    {
        [BsonId]
        ObjectId _id;

        [Required (ErrorMessage = "Введите логин")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Введите ваше имя")]
        public string? Name { get; set; }

        [Phone(ErrorMessage = "Введите ваш номер телефона")]
        public string? Phone { get; set; }

        [EmailAddress (ErrorMessage = "Введите вашу почту")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Введите ваш пароль")]
        public string? Password { get; set; }

        public string Status { get; set; } = "Empoyee";

    }
}
