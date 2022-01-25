using System;

namespace WebSalesSystem.Services.Exceptions
{
    public class DbConcurrencyExeption : ApplicationException
    {
        public DbConcurrencyExeption(string message) : base(message)
        {

        }


    }
}
