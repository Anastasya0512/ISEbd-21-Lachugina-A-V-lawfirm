using LawFirmDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace LawFirmDatabaseImplement
{
    public class LawFirmDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-9DR7V1JH;Initial Catalog=LawFirmDatabaseUsl;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }

        public virtual DbSet<Document> Documents { set; get; }

        public virtual DbSet<DocumentComponent> DocumentComponents { set; get; }

        public virtual DbSet<Order> Orders { set; get; }

        public virtual DbSet<Warehouse> Warehouses { get; set; }

        public virtual DbSet<WarehouseComponent> WarehouseComponents { set; get; }

        public virtual DbSet<Client> Clients { set; get; }
    }
}
