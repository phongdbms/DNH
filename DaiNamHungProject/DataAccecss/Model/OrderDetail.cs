using DataAccecss.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccecss.Model
{
    [Table("OrderDetails")]
    public class OrderDetail : Auditable
    {

        [Key]
        public Guid OrderDetailID { set; get; }
        public Guid OrderID { set; get; }
        
        public Guid ProductID { set; get; }

        public int Quantitty { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}