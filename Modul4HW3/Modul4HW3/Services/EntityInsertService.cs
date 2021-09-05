using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modul4HW3.Entities;

namespace Modul4HW3.Services
{
    public class EntityInsertService
    {
        public void InsertEmployees(DbContext appContext)
        {
            InsertIn(appContext, GetEmployees());
        }

        public void InsertEmployeeProject(DbContext appContext)
        {
            InsertIn(appContext, GetEmployeeProject());
        }

        public void InsertProjects(DbContext appContext)
        {
            InsertIn(appContext, GetProjects());
        }

        public void InsertOffices(DbContext appContext)
        {
            InsertIn(appContext, GetOffices());
        }

        public void InsertTitles(DbContext appContext)
        {
            InsertIn(appContext, GetTitles());
        }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    FirstName = "Vlad",
                    LastName = "Vladov",
                    DateOfBirth = new DateTime(1999, 10, 13),
                    HiredDate = new DateTime(2020, 1, 3),
                    OfficeId = 1,
                    TitleId = 1
                },

                new Employee
                {
                    Id = 2,
                    FirstName = "Ivan",
                    LastName = "Stepanov",
                    DateOfBirth = new DateTime(1990, 5, 4),
                    HiredDate = new DateTime(2020, 1, 30),
                    OfficeId = 1,
                    TitleId = 1
                },

                new Employee
                {
                    Id = 3,
                    FirstName = "Mark",
                    LastName = "Fedorov",
                    DateOfBirth = new DateTime(1954, 7, 18),
                    HiredDate = new DateTime(2000, 6, 6),
                    OfficeId = 2,
                    TitleId = 2
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Tom",
                    LastName = "Black",
                    DateOfBirth = new DateTime(1968, 11, 15),
                    HiredDate = new DateTime(2010, 6, 6),
                    OfficeId = 2,
                    TitleId = 2
                },
            };
        }

        public List<EmployeeProject> GetEmployeeProject()
        {
            return new List<EmployeeProject>
            {
                new EmployeeProject
                {
                    Id = 1,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 1,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 2,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 2,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 3,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 3,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    Id = 4,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 4,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    Id = 5,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 2,
                    EmployeeId = 3,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 6,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 3,
                    EmployeeId = 4,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    Id = 7,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 5,
                    EmployeeId = 3,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    Id = 8,
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 4,
                    EmployeeId = 1,
                    Rate = 100,
                }
            };
        }

        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Id = 1,
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1550,
                    Name = "MyBestFrameWork",
                    ClientId = 1
                },
                new Project
                {
                    Id = 2,
                    StartedDate = new DateTime(2020, 4, 1),
                    Budget = 15500,
                    Name = "MyBestWebSite",
                    ClientId = 2
                },
                new Project
                {
                    Id = 3,
                    StartedDate = new DateTime(2021, 8, 6),
                    Budget = 15750,
                    Name = "antivirus",
                    ClientId = 3
                },
                new Project
                {
                    Id = 4,
                    StartedDate = new DateTime(1991, 11, 23),
                    Budget = 1550,
                    Name = "SomeProject",
                    ClientId = 4
                },
                new Project
                {
                    Id = 5,
                    StartedDate = new DateTime(2001, 11, 15),
                    Budget = 1550,
                    Name = "SomeService",
                    ClientId = 5
                }
            };
        }

        public List<Office> GetOffices()
        {
            var list = new List<Office>();
            list.Add(
                    new Office
                    {
                        Id = 1,
                        Location = "USA, NewYork",
                        Title = "IT Office"
                    });
            list.Add(
                   new Office
                   {
                       Id = 2,
                       Location = "Ukraine, Kharkiv",
                       Title = "Zavod"
                   });
            return list;
        }

        public List<Title> GetTitles()
        {
            return new List<Title>
            {
                new Title
                {
                    Id = 1,
                    Name = "Programmer"
                },
                new Title
                {
                    Id = 2,
                    Name = "Worker"
                }
            };
        }

        public List<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    Id = 1,
                    FirstName = "Henry",
                    LastName = "Ford",
                    DateOfBirth = new DateTime(1943, 2, 18),
                    Revenue = 269000
                },

                new Client
                {
                    Id = 2,
                    FirstName = "Pasha",
                    LastName = "Pavlov",
                    DateOfBirth = new DateTime(1993, 9, 8),
                    Revenue = 70000000,
                },
                new Client
                {
                    Id = 3,
                    FirstName = "Max",
                    LastName = "Maximov",
                    DateOfBirth = new DateTime(1977, 12, 18),
                    Revenue = 29990
                },
                new Client
                {
                    Id = 4,
                    FirstName = "Liza",
                    LastName = "Lizova",
                    DateOfBirth = new DateTime(2000, 8, 20),
                    Revenue = 130000
                },
                new Client
                {
                    Id = 5,
                    FirstName = "Don",
                    LastName = "Red",
                    DateOfBirth = new DateTime(1934, 2, 10),
                    Revenue = 13000
                }
            };
        }

        private void InsertIn<T>(DbContext context, IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                context.Add(item);
                context.SaveChanges();
            }
        }
    }
}
