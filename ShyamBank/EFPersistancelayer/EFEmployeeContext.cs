using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShyamBank.Controllers;
using ShyamBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShyamBank.EFPersistancelayer
{
    public class EFEmployeeContext : Controller
    {


        public static bool Create(Employee employee)
        {
            string ConnectionString = "Server=(localdb)\\shyam;Database=ShyamBank;User Id=shyam;Password=shyam;encrypt=false";
            try
            {
                DbContextOptionsBuilder<ShyamBankContext> optionsBuilder = new DbContextOptionsBuilder<ShyamBankContext>();
                optionsBuilder.UseSqlServer(ConnectionString);
                ShyamBankContext db = new ShyamBankContext(optionsBuilder.Options);
                db.Employees.Add(employee);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }



        public static List<Employee> GetEmployees()
        {
            string ConnectionString = "Server=(localdb)\\shyam;Database=ShyamBank;User Id=shyam;Password=shyam;encrypt=false";

            try
            {
                DbContextOptionsBuilder<ShyamBankContext> optionsBuilder = new DbContextOptionsBuilder<ShyamBankContext>();
                optionsBuilder.UseSqlServer(ConnectionString);
                ShyamBankContext db = new ShyamBankContext(optionsBuilder.Options);
                List<Employee> employee= db.Employees.ToList();
                db.SaveChanges();
                return employee;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Employee Login(string userName, string password)
        {
           
        }
    }
}
