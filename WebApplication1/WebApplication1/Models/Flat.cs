using System.Collections;
using System.Collections.Generic;
using WebApplication1.DataProvider;

namespace WebApplication1.Models
{
    public class Flat : Entity
    {
        public static Repository<Flat> Repository => new Repository<Flat>();
        
        /// <summary>
        /// Кол-во комнат
        /// </summary>
        public int RoomCount { get; set; }

        /// <summary>
        /// Площадь
        /// </summary>
        public double Square { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address{ get; set; }
        
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Ссылки на фотографии
        /// </summary>
        public IEnumerable<string> Photos { get; set; }
        
        /// <summary>
        /// Рейтинг квартиры
        /// </summary>
        public double Rating { get; set; }
    }
}