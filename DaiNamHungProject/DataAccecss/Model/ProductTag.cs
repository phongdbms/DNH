using DataAccecss.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccecss.Model
{
    [Table("ProductTags")]
    public class ProductTag: Auditable
    {
        [Key]
        public Guid ProductTagID { set; get; }
        public Guid ProductID { set; get; }
        public Guid TagID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}