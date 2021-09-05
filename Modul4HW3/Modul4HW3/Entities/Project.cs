using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW3.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public int ClientId { get; set; }
        public List<EmployeeProject> EmployeeProject { get; set; } = new List<EmployeeProject>();
        public Client Client { get; set; }
    }
}
