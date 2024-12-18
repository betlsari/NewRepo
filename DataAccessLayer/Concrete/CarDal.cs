using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // The CarDal class implements the ICarDal interface and provides the concrete data access methods for Car entities.
    public class CarDal : ICarDal
    {
        // Retrieves a car by its unique identifier (ID) from the database.
        public Car GetById(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Cars.FirstOrDefault(c => c.CarId == id);
            }
        }

        // Retrieves a list of all cars from the database.
        public List<Car> GetAll()
        {
            using (var context = new AppDbContext())
            {
                return context.Cars.ToList();
            }
        }

        // Adds a new car to the database.
        public void Add(Car car)
        {
            using (var context = new AppDbContext())
            {
                context.Cars.Add(car); // Adds the car to the context.
                context.SaveChanges(); // Saves changes to the database.
            }
        }

        // Updates an existing car in the database.
        public void Update(Car car)
        {
            using (var context = new AppDbContext())
            {
                var existingCar = context.Cars.FirstOrDefault(c => c.CarId == car.CarId); // Finds the car to update.
                if (existingCar != null)
                {
                    existingCar.Model = car.Model; // Updates the car model.
                    existingCar.Price = car.Price; // Updates the car price.

                    context.SaveChanges(); // Saves changes to the database.
                }
            }
        }

        // Deletes a car from the database.
        public void Delete(Car car)
        {
            using (var context = new AppDbContext())
            {
                var carToDelete = context.Cars.FirstOrDefault(c => c.CarId == car.CarId); // Finds the car to delete.
                if (carToDelete != null)
                {
                    context.Cars.Remove(carToDelete); // Removes the car from the context.
                    context.SaveChanges(); // Saves changes to the database.
                }
            }
        }

        // Specific method for getting available cars
        // Retrieves a list of cars that are available for rent, excluding cars that are currently rented.
        public List<Car> GetAvailableCars()
        {
            using (var context = new AppDbContext())
            {
                DateTime today = DateTime.Now; // Gets the current date and time.

                // Excludes cars that are currently rented and have an ongoing rental.
                var unavailableCarIds = context.Rentals
                    .Where(r => r.EndDate >= today) // Finds rentals that have an end date in the future (still active).
                    .Select(r => r.CarId) // Gets the car IDs of these rentals.
                    .Distinct() // Ensures unique car IDs.
                    .ToList();

                // Returns cars that are available and not in the list of unavailable cars.
                return context.Cars
                    .Where(c => c.isAvailable && !unavailableCarIds.Contains(c.CarId))
                    .ToList();
            }
        }
    }
}
