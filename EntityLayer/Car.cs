using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    // The Car class defines the properties and behavior of a car object.
    public class Car
    {
        // Default constructor, creates a Car object but doesn't take any parameters.
        public Car()
        {
        }

        // Parameterized constructor, initializes a Car object with car ID, model, price, availability status, and favorite status.
        public Car(int carId, string model, int price, bool isAvailable)
        {
            CarId = carId; // Assigns the car ID.
            Model = model; // Assigns the model name.
            Price = price; // Assigns the car price.
            this.isAvailable = isAvailable; // Assigns the availability status.
           // Assigns the favorite status.
        }

        // The car's unique identifier (ID).
        public int CarId { get; set; }

        // The model of the car, for example: "Toyota Corolla".
        public string Model { get; set; }

        // The price of the car, stored as an integer.
        public int Price { get; set; }

        // A boolean that indicates whether the car is available. If true, the car is available.
        public bool isAvailable { get; set; }

        // A boolean that indicates whether the car is marked as a favorite. Default value is false.
     
    }
}
