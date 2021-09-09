﻿using System.Collections.Generic;

namespace Modul4HW3.Entities
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}