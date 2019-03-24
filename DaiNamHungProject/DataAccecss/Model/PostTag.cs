using DataAccecss.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccecss.Model
{
    [Table("PostTags")]
    public class PostTag:Auditable
    {
        [Key]
        public Guid PostTagId { set; get; }
        public Guid PostID { set; get; }  
        public Guid TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}