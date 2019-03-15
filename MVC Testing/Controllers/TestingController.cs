using MVC_Testing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Testing.Controllers
{
    public class TestingController : Controller
    {
        // GET: Testing
        public ActionResult Index()
        {
            //ViewBag.No = "18";

            //List<string> data = new List<string>();
            //data.Add("dhruv");
            //data.Add("mevada");

            //ViewBag.datalist = data;


            List<employee> employeelist = new List<employee>();
            employee emp = new employee();

            employeelist.Add(new employee { Id = 1, name = "test", department = "test" });
            employeelist.Add(new employee { Id = 2, name = "test2", department = "test2" });
            employeelist.Add(new employee { Id = 3, name = "test3", department = "test3" });

            return View(employeelist);
        }
        public string Test()
        {
            ViewBag.No = "18";
            return "drhuv";
        }


    }
}