using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team_Selector.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public string imgUrl { get; set; }
        public bool Available { get; set; }
    }

    public class Job
    {
        public string Title { get; set; }
    }

    public class Equipment
    {
        public string Title { get; set; }
        public bool Available { get; set; }
    }

    public class Role
    {
        public string Title { get; set; }
        public string Colour { get; set; }
    }

    public class Data
    {
        public List<Job> Jobs { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Equipment> Equipments { get; set; }
        public List<Role> Roles { get; set; }
    }
}
