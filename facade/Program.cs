using System;

namespace facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCar();

            Console.ReadKey();
        }
    }

    class CarModel
    {
        public void Create()
        {
            Console.WriteLine("Model - OK");
        }
    }

    class CarEngine
    {
        public void Create()
        {
            Console.WriteLine("Engine - OK");
        }
    }

    class CarBody
    {
        public void Create()
        {
            Console.WriteLine("Body - OK");
        }
    }

    class CarAccessories
    {
        public void Create()
        {
            Console.WriteLine("Accessories - OK");
        }
    }

    class CarFacade
    {
        CarModel model;
        CarEngine engine;
        CarBody body;
        CarAccessories accessories;
        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.Create();
            engine.Create();
            body.Create();
            accessories.Create();
            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
