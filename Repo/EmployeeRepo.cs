using Database.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public class EmployeeRepo: IEmployeeRepo
    {
        public bool AddEmployee(Employee employee)
        {
            using (var context = new EmployeeDBContext())
            {
                Simple emp = new Simple();
                emp.Id = employee.ID;
                emp.Name = employee.Name;
                emp.Department = employee.Department;
                context.Simple.Add(emp);
                context.SaveChanges();
            }
            return true;
        }
    }
}
