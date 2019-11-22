using System.Data.Entity;
using Project.Core.Entities;

namespace Project.Core.Connection
{
    public class ConnectionDb:DbContext
    {
        public ConnectionDb():base("ArabaData")
        {
            Database.SetInitializer(new Initializer());
        }
        public virtual DbSet<Car> GetCars { get; set; }
        public virtual DbSet<Model> GetModels { get; set; }
        public virtual DbSet<Brand> GetBrands { get; set; }
    }
}
