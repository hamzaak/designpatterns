/*
    > Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system.
    > This pattern involves a single wrapper class which contains a set of members which are required by the client. 
      These members access the system on behalf of the facade client and hide the implementation details.
    > The facade design pattern is particularly used when a system is very complex or difficult to understand 
      because the system has a large number of interdependent classes or its source code is unavailable.
*/

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
