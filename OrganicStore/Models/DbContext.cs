using Microsoft.EntityFrameworkCore;

namespace OrganicStore.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<products> Products { get; set; }   
    }
}
