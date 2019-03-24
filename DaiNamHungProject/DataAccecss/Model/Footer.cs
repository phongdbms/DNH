using DataAccecss.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccecss.Model
{
    [Table("Footers")]
    public class Footer : Auditable
    {
        [Key]
        public Guid ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}