using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Favorite
    {
        public Favorite()
        {
        }

        public Favorite(int favoriteId, int carId, int userId)
        {
            FavoriteId = favoriteId;
            CarId = carId;
            UserId = userId;
        }

        public int FavoriteId { get; set; }
        public int CarId { get; set; }   // Araba Id'si
        public int UserId { get; set; }  // Kullanıcı Id'si (isteğe bağlı)
    }
}
