using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSalesSystem.Data;
using WebSalesSystem.Models;
using WebSalesSystem.Services;

namespace WebSalesSystem.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientService _clientService;

        public ClientsController(ClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _clientService.FindAllAsync();

            return View(list); 
        }

        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Client client)
        {
            _clientService.Insert(client);
            return RedirectToAction(nameof(Index));   
        }





















    }
}
