using Microsoft.EntityFrameworkCore;

namespace E_commerce_Mvc_app.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
