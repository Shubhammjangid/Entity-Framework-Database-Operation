using Database.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public interface IEmployeeRepo
    {
        bool AddEmployee(Employee employee);

        List<Simple> ShowDetail ();

        Simple Details(int Id);

        bool EditList(int id, Simple simple);

        bool DeleteList(int id);
    }

    
}
