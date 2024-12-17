using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class FavoritesForm : Form
    {
        public FavoritesForm()
        {
            InitializeComponent();
           
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {
            ListFavoriteCars();
        }
        private void ListFavoriteCars()
        {
            using (AppDbContext context = new AppDbContext())
            {
                var favoriteCars = from favorite in context.Favorites
                                   join car in context.Cars
                                   on favorite.CarId equals car.CarId
                                   select new
                                   {
                                       car.CarId,
                                       car.Model,
                                       car.Price
                                   };

                dgwFavorites.DataSource = favoriteCars.ToList();
            }
        }
    }
}
