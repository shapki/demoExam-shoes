namespace shoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        public int IdOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DeliveryDate { get; set; }

        public int OfficeId { get; set; }

        public int UserId { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(70)]
        public string Status { get; set; }

        public virtual Office Office { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
