using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSalesSystem.Data;
using WebSalesSystem.Models;
using WebSalesSystem.Models.ViewModels;
using WebSalesSystem.Services;
using WebSalesSystem.Services.Exceptions;

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
        public async Task<IActionResult> Create(Client client)
        {
            if (!ModelState.IsValid)
            {
                return View(client);
            }

            await _clientService.InsertAsync(client);
            return RedirectToAction(nameof(Index));   
        }


        //Update Pag
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
                

            var obj = await _clientService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            

            return View(obj);
        }


        //Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Client client)
        {
           


            if (id != client.Id)
            {
                 return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
                
            }

            try
            {
               await _clientService.UpdateAsync(client);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message }); 
            }
            



        }


        //Tela de confirmacao para delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _clientService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }




        //Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
           await _clientService.RemoveAsync(id);
            return RedirectToAction(nameof(Index)); 
        }



        //Pag para detalhes 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }

            var obj = await _clientService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }


        //Pag de erro

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }




    }
}
