using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutheDemo.Models
{
    interface IEmployeeRepository
    {
        Employee Create(Employee employee);

        Employee Edit(Employee employee);
        
        IEnumerable<Employee> Gets();

        Employee Get(int id);
    }
}
