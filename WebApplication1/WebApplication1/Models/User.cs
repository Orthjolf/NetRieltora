using System;
using WebApplication1.Enums;

namespace WebApplication1.Models
{
    public class User : Entity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Рейтинг
        /// </summary>
        public double Rating { get; set; }
        
        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime RegistrationDate { get; set; }
        
        /// <summary>
        /// Имеет ли пользователь доступ
        /// </summary>
        public bool HasAccess { get; set; }
    }
}