using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // The RentalDal class implements the IRentalDal interface and provides concrete data access methods for rental entities.
    public class RentalDal : IRentalDal
    {
        // Retrieves a rental by its unique identifier (ID).
        public Rental GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.FirstOrDefault(r => r.RentalId == id); // Fetches the rental with the specified RentalId.
            }
        }

        // Retrieves a list of all rentals from the database.
        public List<Rental> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.ToList(); // Fetches all rentals.
            }
        }

        // Adds a new rental to the database.
        public void Add(Rental rental)
        {
            using (var context = new AppDbContext())
            {
                context.Rentals.Add(rental); // Adds the rental to the Rentals table.
                context.SaveChanges(); // Commits the changes to the database.
            }
        }

        // Updates an existing rental in the database.
        public void Update(Rental rental)
        {
            using (var context = new AppDbContext())
            {
                var existingRental = context.Rentals.FirstOrDefault(r => r.RentalId == rental.RentalId); // Finds the rental to update.
                if (existingRental != null)
                {
                    existingRental.CarId = rental.CarId; // Updates the CarId.
                    existingRental.UserId = rental.UserId; // Updates the UserId.
                    existingRental.StartDate = rental.StartDate; // Updates the StartDate.
                    existingRental.EndDate = rental.EndDate; // Updates the EndDate.

                    context.SaveChanges(); // Commits the changes to the database.
                }
            }
        }

        // Deletes a rental from the database.
        public void Delete(Rental rental)
        {
            using (var context = new AppDbContext())
            {
                var rentalToDelete = context.Rentals.FirstOrDefault(r => r.RentalId == rental.RentalId); // Finds the rental to delete.
                if (rentalToDelete != null)
                {
                    context.Rentals.Remove(rentalToDelete); // Removes the rental from the Rentals table.
                    context.SaveChanges(); // Commits the changes to the database.
                }
            }
        }

        // Retrieves all rentals associated with a specific car by its car ID.
        public List<Rental> GetRentalsByCarId(int carId)
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.Where(r => r.CarId == carId).ToList(); // Fetches rentals for the specified CarId.
            }
        }

        // Retrieves all rentals associated with a specific customer by their user ID.
        public List<Rental> GetRentalsByCustomerId(int userId)
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.Where(r => r.UserId == userId).ToList(); // Fetches rentals for the specified UserId.
            }
        }

        // Retrieves a list of rentals for cars that are available (not currently rented).
        public List<Rental> GetAvailableCars()
        {
            using (var context = new AppDbContext())
            {
                return context.Rentals.Where(r => r.EndDate == null).ToList(); // Returns rentals that don't have an EndDate (still ongoing).
            }
        }

        // Retrieves a list of rentals with associated car models.
        public List<object> GetRentalsWithCarModels()
        {
            using (AppDbContext context = new AppDbContext())
            {
                // Join Rentals with Cars and select relevant rental and car data.
                var rentalsWithCars = from rental in context.Rentals
                                      join car in context.Cars
                                      on rental.CarId equals car.CarId
                                      select new
                                      {
                                          RentalId = rental.RentalId,
                                          Model = car.Model, // Car model.
                                          UserId = rental.UserId,
                                          StartDate = rental.StartDate,
                                          EndDate = rental.EndDate
                                      };

                return rentalsWithCars.ToList<object>(); // Returns the joined list as a list of objects.
            }
        }
    }
}
