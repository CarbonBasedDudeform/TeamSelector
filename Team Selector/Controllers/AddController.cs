using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team_Selector.Models;

namespace Team_Selector.Controllers
{
    public class AddController : Controller
    {
        //private static List<Employee> _employees = new List<Employee>();
        private static Data _data = new Data();

        public ActionResult Index()
        {
            if (_data.Employees == null)
            {
                _data.Employees = new List<Models.Employee>();
            }

            if (_data.Jobs == null)
            {
                _data.Jobs = new List<Models.Job>();
            }

            if (_data.Equipments == null)
            {
                _data.Equipments = new List<Models.Equipment>();
            }

            if (_data.Roles == null)
            {
                _data.Roles = new List<Models.Role>();
            }

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";


            return View(_data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View(_data);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(_data);
        }

        public ActionResult Employee()
        {
            ViewBag.Message = "Your employee page.";

            return View(_data);
        }

        public ActionResult EmployeeRole()
        {
            ViewBag.Message = "Your employee Role page.";

            return View(_data);
        }

        public ActionResult AddEmployee(string Name, string Role, string RoleColour, string imgUrl)
        {
            Team_Selector.Models.Employee temp = new Employee();
            temp.Name = Name;
            temp.Role = new Models.Role();
            temp.Role.Title = Role;
            temp.Role.Colour = RoleColour;
            temp.imgUrl = imgUrl;
            temp.Available = true;

            if (_data.Employees == null)
            {
                _data.Employees = new List<Models.Employee>();
            }

            _data.Employees.Add(temp);

            return View("Index", _data);
        }

        public ActionResult AddEmployeeRole(string Role, string Colour)
        {
            if (_data.Roles == null) _data.Roles = new List<Role>();

            Role temp = new Models.Role();
            temp.Title = Role;
            temp.Colour = Colour;

            _data.Roles.Add(temp);

            return View("Index", _data);
        }

        public ActionResult Job()
        {
            ViewBag.Message = "Add a new Job";

            return View(_data);
        }

        public ActionResult AddJob(string Title)
        {
            Team_Selector.Models.Job temp = new Job();
            temp.Title = Title;

            if (_data.Jobs == null)
            {
                _data.Jobs = new List<Models.Job>();
            }

            _data.Jobs.Add(temp);

            return View("Index", _data);
        }

        public ActionResult Equipment()
        {
            return View(_data);
        }

        public ActionResult AddEquipment(string Title)
        {
            Team_Selector.Models.Equipment temp = new Equipment();
            temp.Title = Title;
            temp.Available = true;

            if (_data.Equipments == null)
            {
                _data.Equipments = new List<Models.Equipment>();
            }

            _data.Equipments.Add(temp);

            return View("Index", _data);
        }
    }
}
