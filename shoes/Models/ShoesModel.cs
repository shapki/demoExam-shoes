using System.Data.Entity;

namespace shoes.Models
{
    public partial class ShoesModel : DbContext
    {
        public ShoesModel()
            : base("name=ShoesModel")
        {
        }

        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Supplyer> Supplyer { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.ManufacturerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Office>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Office)
                .HasForeignKey(e => e.OfficeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderProduct)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderProduct)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplyer>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Supplyer)
                .HasForeignKey(e => e.SupplyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
