using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Hamza";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";
            Console.WriteLine(dev.GetDetails());

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif";
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Burcu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;
            Console.WriteLine(typist.GetDetails());

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Onur";
            typistCopy.WordsPerMinute = 115;
            Console.WriteLine(typistCopy.GetDetails());

            Console.ReadKey();
        }
    }

    public abstract class EmployeePrototype
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public EmployeePrototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (EmployeePrototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (IEmployee)this.Clone();
        }

        public abstract string GetDetails(); 
    }

    public class Developer : EmployeePrototype
    {
        public string PreferredLanguage { get; set; }
        public override string GetDetails()
        {
            return $"{Name} - {Role} - {PreferredLanguage}";
        }
    }

    public class Typist : EmployeePrototype
    {
        public int WordsPerMinute { get; set; }
        public override string GetDetails()
        {
            return $"{Name} - {Role} - {WordsPerMinute}wpm";
        }
    }
}
