using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // The ICarDal interface defines the data access methods for Car entities.
    public interface ICarDal
    {
        // Gets a car by its unique identifier (ID).
        Car GetById(int id);

        // Retrieves a list of all cars.
        List<Car> GetAll();

        // Adds a new car to the database.
        void Add(Car car);

        // Updates an existing car in the database.
        void Update(Car car);

        // Deletes a car from the database.
        void Delete(Car car);

        // Specific methods for cars

        // Retrieves a list of available cars.
        List<Car> GetAvailableCars();
    }
}
