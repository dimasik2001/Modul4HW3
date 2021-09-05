using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modul4HW3.Services;

namespace Modul4HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigService();
            var creator = new EntityInsertService();
            var offices = creator.GetOffices();
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            var option = optionsBuilder.UseSqlServer(config.ConnectionString).Options;
            using (var db = new AppContext(option))
            {
                db.Titles.AddRange(creator.GetTitles());
                db.SaveChanges();
                db.Offices.AddRange(creator.GetOffices());
                db.SaveChanges();
                db.Projects.AddRange(creator.GetProjects());
                db.SaveChanges();
                db.Employees.AddRange(creator.GetEmployees());
                db.SaveChanges();
                db.EmployeeProject.AddRange(creator.GetEmployeeProject());
                db.SaveChanges();
                var office = db.Offices.FirstOrDefault(t => t.Title == "Zavod");
                var r = db.Employees.FirstOrDefault(t => t.Office == office);
                Console.WriteLine(r.LastName);
            }

            Console.WriteLine("done");
        }
    }
}
