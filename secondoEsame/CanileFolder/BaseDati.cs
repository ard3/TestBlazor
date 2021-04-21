using Microsoft.EntityFrameworkCore;

namespace secondoEsame.CanileFolder
{
    public class BaseDati : DbContext
    {
        public DbSet<Canile> canili { get; set; }

        public BaseDati(DbContextOptions options) : base(options)
        { }
    }
}
