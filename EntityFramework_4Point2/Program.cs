using EntityFramework_4Point2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework_4Point2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Please enter a manufacturer: ");
            input = Console.ReadLine().Trim();

            // Dispose of whatever is in the parentheses when the code block ends.
            using (VehicleContext context = new VehicleContext())
            {
                try
                {
                    // 1. Access Context.
                    // 2. Access the Manufacturer table.
                    // 3. Filter the Manufacturer table to the one that matches.
                    // 4. Convert the collection of one item to a single item.
                    // 5. Access the Vehicles table and match the keys.
                    // 6. Convert that collection to a list.
                    Manufacturer manufacturer = context.Manufacturers.Where(x => x.Name.ToLower() == input.ToLower()).Single();

                    List<Vehicle> vehicles = context.Vehicles.Where(x => x.ManufacturerId == manufacturer.Id).ToList();

                    foreach (Vehicle vehicle in vehicles)
                    {
                        Console.WriteLine($"-{vehicle.Colour} {vehicle.ModelYear} {vehicle.Model}");
                    }
                }
                catch
                {
                    Console.WriteLine("ERROR: Please ensure input is valid and try again.");
                }
            }
        }
    }
}
