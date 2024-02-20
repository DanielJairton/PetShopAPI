using Microsoft.EntityFrameworkCore;
using PetShopAPI.Models;

namespace PetShopAPI.Context
{
    public class PetDbContext : DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext>options): base(options)
        {

        }

        public DbSet<Pet>Pets { get; set; }
    }
}
