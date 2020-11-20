using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Web.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        public List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1 , Name = "Tom" ,Email = "tom@gmail.com",Department =Dept.HR},
                new Employee() {Id = 2 , Name = "Jerry" ,Email = "jerry@gmail.com",Department =Dept.IT},
                new Employee() {Id = 3 , Name = "Dorimon" ,Email = "dorimon@gmail.com",Department =Dept.None},
            };
        }

        public Employee Add(Employee employee)
        {
           employee.Id= _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

    }
}
