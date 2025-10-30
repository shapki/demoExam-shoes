using System.Data.Entity;

namespace shoes.Models
{
    public partial class ShoesModel : DbContext
    {
        public ShoesModel()
            : base("name=ShoesModel")
        {
        }

        public virtual DbSet<manufacturer> manufacturer { get; set; }
        public virtual DbSet<office> office { get; set; }
        public virtual DbSet<orderProduct> orderProduct { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<supplyer> supplyer { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<manufacturer>()
                .HasMany(e => e.products)
                .WithRequired(e => e.manufacturer)
                .HasForeignKey(e => e.manufacturerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<office>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.office)
                .HasForeignKey(e => e.officeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orders>()
                .HasMany(e => e.orderProduct)
                .WithRequired(e => e.orders)
                .HasForeignKey(e => e.orderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<products>()
                .HasMany(e => e.orderProduct)
                .WithRequired(e => e.products)
                .HasForeignKey(e => e.productId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<supplyer>()
                .HasMany(e => e.products)
                .WithRequired(e => e.supplyer)
                .HasForeignKey(e => e.supplyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.userId)
                .WillCascadeOnDelete(false);
        }
    }
}
