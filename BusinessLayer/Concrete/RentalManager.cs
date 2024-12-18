using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    // The RentalManager class implements IRentalManager and provides business logic for managing rental entities.
    public class RentalManager : IRentalManager
    {
        private readonly IRentalDal _rentalDal;  // Dependency for data access layer for Rentals

        // Constructor that injects dependencies (IRentalDal).
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        // Retrieves all rentals from the system.
        public List<Rental> GetAllRentals()
        {
            return _rentalDal.GetAll();  // Fetches all rentals using the data access layer.
        }

        // Adds a new rental to the system.
        public void AddRental(Rental rental)
        {
            // Business logic can be added here (e.g., checking if the car is available).
            var car = _rentalDal.GetRentalsByCarId(rental.CarId);  // Checks if the car is already rented.
            if (car != null && car.Count > 0)
            {
                throw new Exception("This car is already rented.");
            }

            _rentalDal.Add(rental);  // Adds the rental using the data access layer.
        }

        // Updates an existing rental.
        public void UpdateRental(Rental rental)
        {
            // Business logic can be added here.
            var existingRental = _rentalDal.GetById(rental.RentalId);  // Retrieves the existing rental by ID.
            if (existingRental == null)
            {
                throw new Exception("Rental to be updated not found.");
            }

            _rentalDal.Update(rental);  // Updates the rental using the data access layer.
        }

        // Deletes a rental by its ID.
        public void DeleteRental(int rentalId)
        {
            var rentalToDelete = _rentalDal.GetById(rentalId);  // Retrieves the rental to delete.
            if (rentalToDelete == null)
            {
                throw new Exception("Rental to be deleted not found.");
            }

            _rentalDal.Delete(rentalToDelete);  // Deletes the rental using the data access layer.
        }

        // Retrieves all rentals for a specific customer.
        public List<Rental> GetRentalsByCustomerId(int customerId)
        {
            return _rentalDal.GetRentalsByCustomerId(customerId);  // Fetches rentals by customer ID using the data access layer.
        }

        // Retrieves available rentals (i.e., rentals for cars that are available).
        public List<Rental> GetAvailableRentals()
        {
            return _rentalDal.GetAvailableCars();  // Fetches available rentals using the data access layer.
        }

        // Retrieves rentals along with associated car models.
        public List<object> GetRentalsWithCarModels()
        {
            return _rentalDal.GetRentalsWithCarModels();  // Fetches rentals with car models using the data access layer.
        }
    }
}
