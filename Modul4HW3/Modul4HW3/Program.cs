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
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var option = optionsBuilder.UseSqlServer(config.ConnectionString).Options;
            using (var db = new ApplicationContext(option))
            {
                /*creator.InsertOffices(db);
                creator.InsertTitles(db);
                creator.InsertEmployees(db);
                creator.InsertProjects(db);
                creator.InsertEmployeeProject(db);*/
                var office = db.Offices.FirstOrDefault(t => t.Title == "Zavod");
                var res1 = db.Employees.FirstOrDefault(t => t.Office == office);
                var project = db.Projects.FirstOrDefault(t => t.Name == "antivirus");
                var res2 = db.Clients.FirstOrDefault(t => t.Projects.Contains(project));
                Console.WriteLine(res2.LastName);
            }

            Console.WriteLine("done");
        }
    }
}
