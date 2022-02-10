using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public interface IEmployeeRepo
    {
        bool AddEmployee(Employee employee);
    }
}
