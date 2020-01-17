using System;
using System.Collections;
using System.Collections.Generic;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Employee Tree Structure
                - Hamza
                    - Sami
                        - Elif
                        - Sonya
                    - Mahmut
                        - Macit
                        - Emre
                        - Cenk
                        - Atilla
            */

            Employee Hamza = new Employee { EmpID = 1, Name = "Hamza" };

            Employee Sami = new Employee { EmpID = 2, Name = "Sami" };
            Employee Mahmut = new Employee { EmpID = 3, Name = "Mahmut" };

            Hamza.AddSubordinate(Sami);
            Hamza.AddSubordinate(Mahmut);

            Employee Elif = new Employee { EmpID = 4, Name = "Elif" };
            Employee Sonya = new Employee { EmpID = 5, Name = "Sonya" };

            Sami.AddSubordinate(Elif);
            Sami.AddSubordinate(Sonya);

            Employee Macit = new Employee { EmpID = 6, Name = "Macit" };
            Employee Emre = new Employee { EmpID = 7, Name = "Emre" };

            Contractor Cenk = new Contractor { EmpID = 8, Name = "Cenk" };
            Contractor Atilla = new Contractor { EmpID = 9, Name = "Atilla" };

            Mahmut.AddSubordinate(Macit);
            Mahmut.AddSubordinate(Emre);
            Mahmut.AddSubordinate(Cenk);
            Mahmut.AddSubordinate(Atilla);

            Console.WriteLine($"EmpID={Hamza.EmpID}, Name={Hamza.Name}");

            foreach (Employee manager in Hamza)
            {
                Console.WriteLine($"   > EmpID={manager.EmpID}, Name={manager.Name}");

                foreach (var employee in manager)
                {
                    Console.WriteLine($"      > EmpID={employee.EmpID}, Name={employee.Name}");
                }
            }

            Console.ReadKey();
        }
    }

    public interface IEmployed
    {
        int EmpID { get; set; }
        string Name { get; set; }
    }

    public class Employee : IEmployed, IEnumerable<IEmployed>
    {
        private List<IEmployed> _subordinates = new List<IEmployed>();

        public int EmpID { get; set; }
        public string Name { get; set; }

        public void AddSubordinate(IEmployed subordinate)
        {
            _subordinates.Add(subordinate);
        }
        public void RemoveSubordinate(IEmployed subordinate)
        {
            _subordinates.Remove(subordinate);
        }
        public IEmployed GetSubordinate(int index)
        {
            return _subordinates[index];
        }
        public IEnumerator<IEmployed> GetEnumerator()
        {
            foreach (IEmployed subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Contractor : IEmployed
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
    }
}
