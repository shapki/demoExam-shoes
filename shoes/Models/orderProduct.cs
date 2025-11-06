namespace shoes.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrderProduct")]
    public partial class OrderProduct
    {
        [Key]
        public int IdOrderProduct { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
