using Database.Entities;
using Model;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

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

        public Simple Details (int Id)
        {
            
                EmployeeDBContext context = new EmployeeDBContext();
                var Detail = context.Simple.Where(x => x.Id == Id).FirstOrDefault();
                return Detail;
            
        }

        public bool EditList(int Id , Simple simple)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            context.Entry(simple).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }

        public bool DeleteList(int id)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            Simple simple = context.Simple.Where(x => x.Id == id).FirstOrDefault();
            context.Simple.Remove(simple);
            context.SaveChanges();
            return true;
        }



    }
}
