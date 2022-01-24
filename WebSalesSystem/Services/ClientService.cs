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







    }
}
