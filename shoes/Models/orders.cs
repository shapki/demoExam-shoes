namespace shoes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            orderProduct = new HashSet<orderProduct>();
        }

        [Key]
        public int idOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime orderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime deliveryDate { get; set; }

        public int officeId { get; set; }

        public int userId { get; set; }

        public int code { get; set; }

        [Required]
        [StringLength(70)]
        public string status { get; set; }

        public virtual office office { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderProduct> orderProduct { get; set; }

        public virtual user user { get; set; }
    }
}
