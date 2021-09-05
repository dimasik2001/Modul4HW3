using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul4HW3.Entities;

namespace Modul4HW3.Services
{
    public class EntityInsertService
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Vlad",
                    LastName = "Vladov",
                    DateOfBirth = new DateTime(1999, 10, 13),
                    HiredDate = new DateTime(2020, 1, 3),
                    OfficeId = 1,
                    TitleId = 1
                },

                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Stepanov",
                    DateOfBirth = new DateTime(1990, 5, 4),
                    HiredDate = new DateTime(2020, 1, 30),
                    OfficeId = 1,
                    TitleId = 1
                },

                new Employee
                {
                    FirstName = "Mark",
                    LastName = "Fedorov",
                    DateOfBirth = new DateTime(1954, 7, 18),
                    HiredDate = new DateTime(2000, 6, 6),
                    OfficeId = 2,
                    TitleId = 2
                },
                new Employee
                {
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
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 1,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 2,
                    Rate = 557,
                },

                new EmployeeProject
                {
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 3,
                    Rate = 100,
                },

                new EmployeeProject
                {
                    StartedDate = new DateTime(2021, 1, 1),
                    ProjectId = 1,
                    EmployeeId = 4,
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
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1550,
                    Name = "MyBestFrameWork",
                }
            };
        }

        public List<Office> GetOffices()
        {
            return new List<Office>()
            {
                new Office
                {
                    Location = "Ukraine, Kharkiv",
                    Title = "Zavod"
                },

                new Office
                {
                    Location = "USA, NewYork",
                    Title = "IT Office"
                },
            };
        }

        public List<Title> GetTitles()
        {
            return new List<Title>
            {
                new Title
                {
                    Name = "Programmer"
                },
                new Title
                {
                    Name = "Worker"
                }
            };
        }
    }
}
