﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ClubOyster_Cursach.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        [BsonIgnoreIfDefault]
        [Required (ErrorMessage = "Введите логин")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Введите ваше имя")]
        [BsonIgnoreIfDefault]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Введите вашу фамилию")]
        [BsonIgnoreIfDefault]
        public string? SecondName { get; set; }

        [Required(ErrorMessage = "Введите ваше отчество")]
        [BsonIgnoreIfDefault]
        public string? Surname { get; set; }

        [Phone(ErrorMessage = "Введите ваш номер телефона")]
        [BsonIgnoreIfDefault]
        public string? Phone { get; set; }

        [EmailAddress (ErrorMessage = "Введите вашу почту")]
        [BsonIgnoreIfDefault]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Введите ваш пароль")]
        [BsonIgnoreIfDefault]
        public string? Password { get; set; }
    }
}
