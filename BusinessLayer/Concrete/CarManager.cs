using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    // The CarManager class implements ICarManager and provides the business logic for managing Car entities.
    public class CarManager : ICarManager
    {
        private readonly ICarDal _carDal;  // Dependency for data access layer for Car
        private readonly IRentalDal _rentalDal;  // Dependency for data access layer for Rental

        // Constructor that injects dependencies (ICarDal).
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        // Retrieves all cars from the data access layer.
        public List<Car> GetAllCars()
        {
            return _carDal.GetAll();
        }

        // Adds a new car, with business logic such as price validation.
        public void AddCar(Car car)
        {
            // Validates that the car price is greater than 0.
            if (car.Price <= 0)
            {
                throw new Exception("Car price must be greater than zero.");
            }

            _carDal.Add(car);  // Adds the car using the data access layer.
        }

        // Updates an existing car, with business logic such as existence check.
        public void UpdateCar(Car car)
        {
            var existingCar = _carDal.GetById(car.CarId);  // Fetches the car to be updated.
            if (existingCar == null)
            {
                throw new Exception("Car to update not found.");
            }

            _carDal.Update(car);  // Updates the car using the data access layer.
        }

        // Deletes a car using its ID, with existence validation.
        public void DeleteCar(int carId)
        {
            var carToDelete = _carDal.GetById(carId);  // Fetches the car to be deleted.
            if (carToDelete == null)
            {
                throw new Exception("Car to delete not found.");
            }

            _carDal.Delete(carToDelete);  // Deletes the car using the data access layer.
        }

        // Retrieves available cars for rent.
        public List<Car> GetAvailableCars()
        {
            return _carDal.GetAvailableCars();
        }

        // Filters cars based on model, price range, and rental period.
        public List<Car> FilterCars(string model, decimal minPrice, decimal maxPrice, DateTime startDate, DateTime endDate)
        {
            var cars = _carDal.GetAll();  // Retrieves all cars.

            // Filters cars by model if provided.
            if (!string.IsNullOrEmpty(model))
            {
                cars = cars.Where(c => c.Model.Contains(model)).ToList();
            }

            // Filters cars by price range.
            cars = cars.Where(c => c.Price >= minPrice && c.Price <= maxPrice).ToList();

            // Filters cars by rental period.
            cars = cars.Where(c =>
            {
                var rentals = _rentalDal.GetRentalsByCarId(c.CarId);  // Retrieves rental history for the car.
                return rentals != null && !rentals.Any(r => r.StartDate >= startDate && r.EndDate <= endDate);  // Ensures the car is not rented during the specified period.
            }).ToList();

            return cars;
        }
    }
}
