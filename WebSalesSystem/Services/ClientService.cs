using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesSystem.Data;
using WebSalesSystem.Models;
using WebSalesSystem.Services.Exceptions;

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
        public async Task<Client> FindByIdAsync(int id)
        {
            return await _context.Client.FirstOrDefaultAsync(obj => obj.Id == id);
        }



        //Create
        public async Task InsertAsync(Client obj)
        {
            _context.Client.Add(obj);
           await _context.SaveChangesAsync(); 
        }


        //Update
        public async Task UpdateAsync(Client obj)
        {
            bool hasAny = await _context.Client.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Client.Update(obj);
               await  _context.SaveChangesAsync();
            }
            catch (DbConcurrencyExeption e)
            {

                throw new DbConcurrencyExeption(e.Message);
            }
            

        }
      
        //Delete
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Client.FindAsync(id);
            _context.Client.Remove(obj);
            await _context.SaveChangesAsync();
        }





    }
}
