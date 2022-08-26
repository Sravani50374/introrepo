using Microsoft.EntityFrameworkCore;
namespace CoreMVC.Models
{
    public class Hospitalcontext : Dbcontext
    {
        public Hospitalcontext(DbcontextOptions<Hospitalcontext> options) : base(options)
        {

        }
        public DbSet<doctor> doctor { get; set; }

    }
}
