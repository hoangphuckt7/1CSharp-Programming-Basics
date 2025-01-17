﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhucHN3
{
    public class Vehicle
    {
        public string Make;
        public string Model;

        public Vehicle( string make, string model)
        {
            Make = make;
            Model = model;
        }
        public void DisplayCar()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}");
        }
    }

    public class Car : Vehicle
    {
        public string FuelType;

        public Car(string make, string model, string fuelType) : base(make, model)
        { 
            FuelType = fuelType;
        }

        //public override string ToString() => $"Make: {Make}, Model: {Model}, FuelType: {FuelType}";
        public void DisplayCarInfo()
        {
            DisplayCar();
            Console.WriteLine($"FuelType: {FuelType}");
        }
    }
}
