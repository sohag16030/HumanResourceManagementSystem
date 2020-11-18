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
                new Employee() {Id = 1 , Name = "mary" ,Email = "marry@gmail.com",Department ="HR"},
                new Employee() {Id = 2 , Name = "jbhry" ,Email = "jbrry@gmail.com",Department ="SQA"},
                new Employee() {Id = 3 , Name = "knkary" ,Email = "kknrry@gmail.com",Department ="DEVELOPMENT"},
                new Employee() {Id = 4 , Name = "mojiry" ,Email = "mokjnry@gmail.com",Department ="HR"},
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
