using System;
using System.Collections.Generic;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public List<string> Accessories { get; set; }
        public Vehicle()
        {
            Accessories = new List<string>();
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Accessories:");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine($"\t{accessory}");
            }
        }
    }

    interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        void SetAccessories();

        Vehicle GetVehicle();
    }

    class HeroBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void SetAccessories()
        {
            _vehicle.Accessories.Add("Seat Cover");
            _vehicle.Accessories.Add("Rear Mirror");
        }

        public void SetBody()
        {
            _vehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            _vehicle.Model = "Hero";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "120 km/hr";
        }
    }

    class HondaBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public void SetAccessories()
        {
            _vehicle.Accessories.Add("Seat Cover");
            _vehicle.Accessories.Add("Rear Mirror");
            _vehicle.Accessories.Add("Helmet");
        }

        public void SetBody()
        {
            _vehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            _vehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            _vehicle.Model = "Honda";
        }

        public void SetTransmission()
        {
            _vehicle.Transmission = "125 km/hr";
        }
    }

    class VehicleCreator
    {
        private readonly IVehicleBuilder _builder;
        public VehicleCreator(IVehicleBuilder builder)
        {
            _builder = builder;
        }

        public void CreateVehicle()
        {
            _builder.SetModel();
            _builder.SetEngine();
            _builder.SetBody();
            _builder.SetTransmission();
            _builder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return _builder.GetVehicle();
        }
    }
}
