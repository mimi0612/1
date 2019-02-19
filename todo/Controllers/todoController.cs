using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace todo.Controllers
{
    public class todoController : Controller
    {
        // GET: todo
        public ActionResult Index()
        {
            return View();
        }
    }
}