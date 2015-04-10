using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class newEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employees1 = new Employee();
            employees1.Id = "Kobe";
            employees1.Name = "寇比";
            employees1.Age = 35;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "Curry";
            employees2.Name = "柯瑞";
            employees2.Age = 30;
            employees.Add(employees2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees1 = new Employee();
            employees1.Id = "Kobe";
            employees1.Name = "寇比";
            employees1.Age = 35;

            return employees1;
               

        }       
    }
}
