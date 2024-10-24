using InvenPro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvenPro.Domain
{
    public class InvenProDbContext: DbContext
    {
      public InvenProDbContext(DbContextOptions<InvenProDbContext> options): base(options)
        {
            
        }

        public DbSet<Suppliers> Suppliers { get; set; }
    }
    
    


}
