using Model;
using Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness
{
    public class EmployeeBussiness: IEmployeeBussiness
    {
        private readonly IEmployeeRepo _EmployeeRepo;
        public EmployeeBussiness(IEmployeeRepo EmployeeRepo)
        {
            _EmployeeRepo = EmployeeRepo;
        }

        public bool AddEmployee(Employee employee)
        {
            return _EmployeeRepo.AddEmployee(employee);
        }
    }
}
