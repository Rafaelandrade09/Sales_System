using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesSystem.Data;
using WebSalesSystem.Models;

namespace WebSalesSystem.Services
{
    public class ClientService
    {
        private readonly WebSalesSystemContext _context;

        public ClientService(WebSalesSystemContext context)
        {
            _context = context;
        }


        //FindAll
        public async Task<List<Client>> FindAllAsync()
        {
            return await _context.Client.ToListAsync();
        }


        //FindById
        public Client FindById(int id)
        {
            return _context.Client.FirstOrDefault(obj => obj.Id == id);
        }



        //Create
        public void Insert(Client obj)
        {
            _context.Client.Add(obj);
            _context.SaveChanges(); 
        }

      
        //Delete
        public void Remove(int id)
        {
            var obj = _context.Client.Find(id);
            _context.Client.Remove(obj);
            _context.SaveChanges();
        }





    }
}
