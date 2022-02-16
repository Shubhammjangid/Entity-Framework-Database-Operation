using Database.Entities;
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

        public List<Simple> ShowDetail()
        {
            return _EmployeeRepo.ShowDetail();
        }

        public Simple Details(int Id)
        {
            return _EmployeeRepo.Details(Id);
        }

        public bool EditList(int Id , Simple simple)
        {
            return _EmployeeRepo.EditList(Id, simple);
        }

        public bool DeleteList(Simple simple)
        {
            return _EmployeeRepo.DeleteList(simple);
        }

        public List<Simple> ExampleList()
        {
            return (_EmployeeRepo.ExampleList());
        }
    }
}
