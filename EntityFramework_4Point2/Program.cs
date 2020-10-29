using EntityFramework_4Point2.Models;
using System;

namespace EntityFramework_4Point2
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleContext context = new VehicleContext();

            context.Vehicle.Add(new Vehicle()
            {
                Id = 9,
                Manufacturer = "Chevrolet",
                Model = "Corvette",
                ModelYear = 1959,
                Colour = "Red"
            });

            context.SaveChanges();
        }
    }
}
