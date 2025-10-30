namespace shoes.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("orderProduct")]
    public partial class orderProduct
    {
        [Key]
        public int idOrderProduct { get; set; }

        public int orderId { get; set; }

        public int productId { get; set; }

        public int amount { get; set; }

        public virtual orders orders { get; set; }

        public virtual products products { get; set; }
    }
}
