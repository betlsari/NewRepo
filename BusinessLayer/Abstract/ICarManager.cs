using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // The ICarManager interface defines the business logic methods for managing Car entities.
    public interface ICarManager
    {
        // Retrieves a list of all cars.
        List<Car> GetAllCars();

        // Adds a new car to the system.
        void AddCar(Car car);

        // Updates an existing car in the system.
        void UpdateCar(Car car);

        // Deletes a car from the system using its unique identifier (ID).
        void DeleteCar(int carId);

        // Specific methods for car-related operations

        // Retrieves a list of available cars for rent.
        List<Car> GetAvailableCars();

        // Filters cars based on model, price range, and rental period.
        List<Car> FilterCars(string model, decimal minPrice, decimal maxPrice, DateTime startDate, DateTime endDate);
    }
}
