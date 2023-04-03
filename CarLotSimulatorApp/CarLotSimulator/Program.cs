using System;
using System.Collections.Generic;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            // X Create a seperate class file called Car
            // X Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // X Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car prius = new Car { Year = 2013,
                Make = "Toyota",
                Model = "Prius",
                EngineNoise = "silence",
                HonkNoise = "beep",
                IsDriveable = true
            };

            Car hummer = new Car
            {
                Year = 2018,
                Make = "GMC",
                Model = "Hummer",
                EngineNoise = "BRRRR",
                HonkNoise = "BEEP",
                IsDriveable = true
            };

            Car granturismo = new Car
            {
                Year = 2022,
                Make = "Maserati",
                Model = "Gran Turismo",
                EngineNoise = "zzzooooom",
                HonkNoise = "HONK",
                IsDriveable = true
            };

            List<Car> cars = new List<Car> { prius, hummer, granturismo };
            foreach (var item in cars) {
                Console.WriteLine("{1} - Year: {0}, Manufacturer: {2},  Engine Noise: {3}, Honk Noise: {4}, Driveable: {5}", 
                    item.Year, item.Model, item.Make, item.EngineNoise, item.HonkNoise, item.IsDriveable);
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            // X At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
