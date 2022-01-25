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
        //Pag de listas de clientes
        public async Task<IActionResult> Index()
        {
            var list = await _clientService.FindAllAsync();

            return View(list); 
        }

        //Chamada para a pag de create
        public IActionResult Create()
        {
            return View();  
        }

        //Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Client client)
        {
            _clientService.Insert(client);
            return RedirectToAction(nameof(Index));   
        }

        //Tela de confirmacao para delete
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var obj = _clientService.FindById(id.Value);

            if (obj == null) return NotFound();

            return View(obj);
        }




        //Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _clientService.Remove(id);
            return RedirectToAction(nameof(Index)); 
        }



        //Pag para detalhes 
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var obj = _clientService.FindById(id.Value);

            if (obj == null) return NotFound();

            return View(obj);
        }









    }
}
