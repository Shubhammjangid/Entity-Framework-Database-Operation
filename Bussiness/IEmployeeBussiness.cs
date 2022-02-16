using Database.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness
{
    public interface IEmployeeBussiness
    {
        bool AddEmployee(Employee employee);

        List<Simple> ShowDetail();

        Simple Details(int Id);

        bool EditList(int id, Simple simple);

        bool DeleteList(Simple simple);

        List<Simple> ExampleList();
    }
}
