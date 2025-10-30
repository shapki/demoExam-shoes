namespace shoes.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public products()
        {
            orderProduct = new HashSet<orderProduct>();
        }

        [Key]
        public int idProduct { get; set; }

        [Required]
        [StringLength(10)]
        public string scu { get; set; }

        [Required]
        [StringLength(70)]
        public string productName { get; set; }

        [Required]
        [StringLength(10)]
        public string unit { get; set; }

        public double price { get; set; }

        public int supplyerId { get; set; }

        public int manufacturerId { get; set; }

        [Required]
        [StringLength(70)]
        public string productCat { get; set; }

        public double discount { get; set; }

        public int stock { get; set; }

        [Required]
        [StringLength(550)]
        public string desk { get; set; }

        [Required]
        [StringLength(150)]
        public string photo { get; set; }

        public virtual manufacturer manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderProduct> orderProduct { get; set; }

        public virtual supplyer supplyer { get; set; }
    }
}
