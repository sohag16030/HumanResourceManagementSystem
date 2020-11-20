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
                new Employee() {Id = 1 , Name = "Tom" ,Email = "tom@gmail.com",Department ="HR"},
                new Employee() {Id = 2 , Name = "Jerry" ,Email = "jerry@gmail.com",Department ="SQA"},
                new Employee() {Id = 3 , Name = "Dorimon" ,Email = "dorimon@gmail.com",Department ="DEVELOPMENT"},
            };
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
