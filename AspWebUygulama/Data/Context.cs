using Microsoft.EntityFrameworkCore;
using AspWebUygulama.Models;

namespace AspWebUygulama.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)  
        {
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
