    namespace shoes.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(10)]
        public string Scu { get; set; }

        [Required]
        [StringLength(70)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(10)]
        public string Unit { get; set; }

        public double Price { get; set; }

        public int SupplyerId { get; set; }

        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(70)]
        public string ProductCat { get; set; }

        public double Discount { get; set; }

        public int Stock { get; set; }

        [Required]
        [StringLength(550)]
        public string Desk { get; set; }

        [StringLength(150)]
        public string Photo { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        public virtual Supplyer Supplyer { get; set; }
    }
}
