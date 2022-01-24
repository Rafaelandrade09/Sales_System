using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebSalesSystem.Models;


namespace WebSalesSystem.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            

            return View();
        }
    }
}
