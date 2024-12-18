using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // The IRentalManager interface defines the contract for rental management operations.
    public interface IRentalManager
    {
        // Retrieves all rentals from the system.
        List<Rental> GetAllRentals();

        // Adds a new rental to the system.
        void AddRental(Rental rental);

        // Updates an existing rental in the system.
        void UpdateRental(Rental rental);

        // Deletes a rental by its ID from the system.
        void DeleteRental(int rentalId);

        // Specific operations for rentals:

        // Retrieves all rentals for a specific customer using the customer's ID.
        List<Rental> GetRentalsByCustomerId(int customerId);

        // Retrieves all available rentals, meaning rentals for cars that are available.
        List<Rental> GetAvailableRentals();

        // Retrieves rentals with associated car models.
        List<object> GetRentalsWithCarModels();
    }
}
