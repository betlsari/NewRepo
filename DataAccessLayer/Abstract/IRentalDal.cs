using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // The IRentalDal interface defines the contract for data access operations related to rental entities.
    public interface IRentalDal
    {
        // Retrieves a rental by its unique identifier (ID).
        Rental GetById(int id);

        // Retrieves a list of all rentals in the system.
        List<Rental> GetAll();

        // Adds a new rental to the system.
        void Add(Rental rental);

        // Updates an existing rental in the system.
        void Update(Rental rental);

        // Deletes a rental from the system.
        void Delete(Rental rental);

        // Specific operations for rentals:

        // Retrieves all rentals associated with a specific car by its car ID.
        List<Rental> GetRentalsByCarId(int carId);

        // Retrieves all rentals associated with a specific customer by their user ID.
        List<Rental> GetRentalsByCustomerId(int userId);

        // Retrieves a list of available cars that are not currently rented.
        List<Rental> GetAvailableCars();

        // Retrieves a list of rentals with associated car models.
        List<object> GetRentalsWithCarModels();
    }
}
