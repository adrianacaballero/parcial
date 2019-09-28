

namespace Caballero.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Caballero.Models.Clown> Clowns { get; set; }
    }
}