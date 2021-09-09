using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Modul4HW3.Services;
using Microsoft.EntityFrameworkCore.Proxies;
using Modul4HW3.Entities;

namespace Modul4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigService();
            var creator = new EntityInsertService();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var option = optionsBuilder.UseSqlServer(config.ConnectionString).UseLazyLoadingProxies().Options;
            using (var db = new ApplicationContext(option))
            {
                // task 1
                var result = db.Employees.Select(t => new { Name = t.FirstName + " " + t.LastName, Title = t.Title.Name, Location = t.Office.Location }).ToArray();

                // task 2
                var result2 = db.Employees.Select(t => new { Name = t.FirstName + " " + t.LastName, Experience = (DateTime.Now - t.HiredDate).TotalDays / 365 }).ToArray();

                // task 3
                var client1 = db.Clients.Find(1);
                client1.LastName = "NewLastname";
                var client2 = db.Clients.Find(2);
                client2.LastName = "OtherNewLastname";
                db.Clients.UpdateRange(client1, client2);
                db.SaveChanges();

                // task 4
                db.Employees.Add(
                   new Employee
                   {
                       LastName = "testov",
                       FirstName = "test",
                       DateOfBirth = DateTime.Today,
                       HiredDate = DateTime.Today,
                       OfficeId = 1,
                       Title = new Title
                       {
                           Name = "Director"
                       },
                       EmployeeProject = new List<EmployeeProject>
                       {
                            new EmployeeProject
                            {
                                StartedDate = DateTime.Today,
                                Rate = 500,
                                Project = new Project
                                {
                                    StartedDate = DateTime.Today,
                                    Budget = 5000,
                                    ClientId = 3,
                                    Name = "TestProject3000"
                                }
                            }
                       }
                   });
                db.SaveChanges();

                // task 5
                db.Employees.Remove(db.Employees.FirstOrDefault(t => t.Title.Name == "Director"));
                db.SaveChanges();

                // task 6
                var result3 = db.Employees
                   .Select(t => new { Name = t.FirstName + " " + t.LastName, Title = t.Title.Name })
                   .ToList()
                   .GroupBy(t => t.Title)
                   .Where(t => !t.Key.Contains("a", StringComparison.OrdinalIgnoreCase));
            }

            Console.WriteLine("done");
        }
    }
}
