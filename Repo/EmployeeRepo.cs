using Database.Entities;
using Microsoft.Data.SqlClient;
using Model;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

//Simple == table in SQL server
//Dept == table
//Usp_Simple == procedure to add new entry in database
//Usp_Delete == procedure to delete existing entry from database
//Usp_Update == procedure to update existing entry from database
//Employee == Employee class from Model layer
namespace Repo
{
    public class EmployeeRepo: IEmployeeRepo
    {
        //TO ADD NEW EMPLOYEE
        public bool AddEmployee(Employee employee)
        {
            using (var context = new EmployeeDBContext())
            {
                var DetailInfo = new List<SqlParameter>();
                //DetailInfo.Add(new SqlParameter("@ID", employee.ID));
                DetailInfo.Add(new SqlParameter("Name", employee.Name));
                DetailInfo.Add(new SqlParameter("@Department", employee.Department));
                context.Database.ExecuteSqlRaw("usp_Simple @Name, @Department ", DetailInfo);
                //Simple emp = new Simple();
                //emp.Id = employee.ID;
                //emp.Name = employee.Name;
                //emp.Department = employee.Department;
                //context.Simple.Add(emp);
                //context.SaveChanges();
            }
            return true;
        }

        
        //TO SHOW ALL RECORDS IN DATABASE[dbo].[Simple]
        public List<Simple> ShowDetail()
        {
            List<Simple> returnList = new List<Simple>();
            using(var context = new EmployeeDBContext())
            {
               var detail = context.Simple.ToList();
               returnList = detail;
            }
            return returnList;
        }

        //Join List with DepID [inner join]
        public List<Simple> ExampleList()
        {
            EmployeeDBContext context = new EmployeeDBContext();
            List<Simple> returnList = new List<Simple>();
            var ff = context.Simple.FromSqlRaw("usp_Example").ToList();
            returnList = ff;
            return returnList;

        }

        //DETAIL OF SEPECIFIC EMPLOYEE
        public Simple Details (int Id)
        {
            
                EmployeeDBContext context = new EmployeeDBContext();
                var Detail = context.Simple.Where(x => x.Id == Id).FirstOrDefault();
                return Detail;
            
        }

        //EDIT THE EXISTING RECORD FROM DATABASE
        public bool EditList(int Id , Simple simple)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            //context.Simple.FromSqlRaw("usp_Update");
            //context.Entry(simple).State = EntityState.Modified;
            //context.SaveChanges();


            //Usp_Update
            var paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", simple.Id));
            paramList.Add(new SqlParameter("@Name", simple.Name));
            paramList.Add(new SqlParameter("@Department", simple.Department));
            context.Database.ExecuteSqlRaw("usp_Update @ID , @Name , @Department", paramList);
            return true;
        }

        public bool DeleteList(Simple simple)
        {

            //int id => parameter
            //Simple simple = context.Simple.Where(x => x.Id == id).FirstOrDefault();
            //context.Simple.Remove(simple);
            //context.SaveChanges();

            //Usp_Delete
            EmployeeDBContext context = new EmployeeDBContext();
            var paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", simple.Id));
            context.Database.ExecuteSqlRaw("usp_Delete @ID", paramList);
            return true;
        }



    }
}
