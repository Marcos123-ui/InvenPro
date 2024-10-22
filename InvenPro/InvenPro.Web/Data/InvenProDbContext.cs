using InvenPro.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvenPro.Web.Data
{
    public class InvenProDbContext: DbContext
    {
      public InvenProDbContext(DbContextOptions<InvenProDbContext> options): base(options)
        {
            
        }

        public DbSet<Suppliers> Supplier { get; set; }
    }
    
    


}
