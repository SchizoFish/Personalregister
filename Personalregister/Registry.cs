using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Registry
    {
        private List<Employee> employees;
        public Registry()
        {
            employees = new List<Employee>();
        }

        // lägger till anställda via Employee klassens konstruktor
        public void AddToRegistry(string name, int pay)
        {
            Employee employee = new Employee(name, pay);
            employees.Add(employee);
        }

        // går över registret och listar inlagda anställda
        public void ReadRegistry()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Namn: " + employee.Name);
                Console.WriteLine("Lön " + employee.Pay);
                Console.WriteLine();
            }
        }
    }
}
