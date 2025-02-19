﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() {
            CarLot.numberOfCars++;
            Console.WriteLine($"Number of Cars: {CarLot.numberOfCars}");
        }
        public int Year {get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise{ get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine(noise);
        }

    }
}
