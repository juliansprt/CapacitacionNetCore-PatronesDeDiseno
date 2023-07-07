using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionNetCore_PatronesDeDiseno.PatronesDiseno.Estructurales
{
	public interface IEmployee
	{
		string Name { get; }

		void PerformDutties();
	}

    public class EmployeeTester : IEmployee
    {
        public string Name { get; private set; }

        public EmployeeTester(string name)
        {
            Name = name;
        }

        public void PerformDutties()
        {
            Console.WriteLine($"{Name} esta desempeñando sus funciones de probar la aplicacion");
        }
    }

    public class EmployeeDeveloper : IEmployee
    {
        public string Name { get; private set; }

        public EmployeeDeveloper(string name)
        {
            Name = name;
        }

        public void PerformDutties()
        {
            Console.WriteLine($"{Name} esta desempeñando sus funciones de desarrollar la aplicacion");
        }
    }

    public class Team : IEmployee
    {
        private readonly List<IEmployee> _employees = new List<IEmployee>();

        public string Name { get; private set; }

        public Team(string name)
        {
            Name = name;
        }

        public void AddMember(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public void RemoveMember(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public void PerformDutties()
        {
            Console.WriteLine($"el equiop {Name} esta realizando sus funciones.");
            foreach (var employee in _employees)
            {
                employee.PerformDutties();
            }
        }

    }
}
