/*
    ### SUPER FACTORY ###
    ---------------------------------------------------------------------------------------------------
    Abstract Factory patterns act a super-factory which creates other factories. 
    This pattern is also called a Factory of factories. 
    In Abstract Factory pattern an interface is responsible for creating a set of related objects, 
    or dependent objects without specifying their concrete classes.
*/
using System;

namespace abstractfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory honda = new HondaFactory();
            VehicleClient hondaclient = new VehicleClient(honda, "Regular");

            Console.WriteLine("******* Honda **********");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            hondaclient = new VehicleClient(honda, "Sports");
            Console.WriteLine(hondaclient.GetBikeName());
            Console.WriteLine(hondaclient.GetScooterName());

            VehicleFactory hero = new HeroFactory();
            VehicleClient heroclient = new VehicleClient(hero, "Regular");

            Console.WriteLine("******* Hero **********");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            heroclient = new VehicleClient(hero, "Sports");
            Console.WriteLine(heroclient.GetBikeName());
            Console.WriteLine(heroclient.GetScooterName());

            Console.ReadKey();
        }
    }

    class VehicleClient
    {
        Bike bike;
        Scooter scooter;
        public VehicleClient(VehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }
        public string GetBikeName()
        {
            return bike.Name();
        }
        public string GetScooterName()
        {
            return scooter.Name();
        }
    }

    interface VehicleFactory
    {
        Bike GetBike(string bike);
        Scooter GetScooter(string scooter);
    }

    class HondaFactory : VehicleFactory
    {
        public Bike GetBike(string bike)
        {
            switch (bike)
            {
                case "Sports": return new SportsBike();
                case "Regular": return new RegularBike();
                default: throw new ApplicationException($"Vehicle '{bike}' cannot be created");
            }
        }

        public Scooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "Sports": return new Scooty();
                case "Regular": return new RegularScooter();
                default: throw new ApplicationException($"Vehicle '{scooter}' cannot be created");
            }
        }
    }

    class HeroFactory : VehicleFactory
    {
        public Bike GetBike(string bike)
        {
            switch (bike)
            {
                case "Sports": return new SportsBike();
                case "Regular": return new RegularBike();
                default: throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bike));
            }
        }

        public Scooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "Sports": return new Scooty();
                case "Regular": return new RegularScooter();
                default: throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", scooter));
            }

        }
    }

    interface Bike
    {
        string Name();
    }

    class RegularBike : Bike
    {
        public string Name()
        {
            return "Regular Bike";
        }
    }

    class SportsBike : Bike
    {
        public string Name()
        {
            return "Sports Bike";
        }
    }

    interface Scooter
    {
        string Name();
    }

    class RegularScooter : Scooter
    {
        public string Name()
        {
            return "Regular Scooter";
        }
    }

    class Scooty : Scooter
    {
        public string Name()
        {
            return "Scooty";
        }
    }
}
