using Database.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public interface IEmployeeRepo
    {
        //Add new entry
        bool AddEmployee(Employee employee);

        //Show all deatil from database EMI [dbo].[Simple]
        List<Simple> ShowDetail ();

        //Show details 
        Simple Details(int Id);

        //Edit the entry
        bool EditList(int id, Simple simple);

        //Delete the entry
        bool DeleteList(Simple simple);

        //inner join [dbo].[Simple] && [dbo][Dept]
        List<Simple> ExampleList();
    }

    
}
