using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSalesSystem.Models;

namespace WebSalesSystem.Data
{
    public class WebSalesSystemContext : DbContext
    {
        public WebSalesSystemContext (DbContextOptions<WebSalesSystemContext> options) : base(options){}

        public DbSet<Client> Client { get; set; }
    }
}
