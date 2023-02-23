namespace EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactTable")]
    public partial class ContactTable
    {
        [Key]
        [StringLength(50)]
        public string P_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string P_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string P_Count { get; set; }

        [Required]
        [StringLength(50)]
        public string P_Price { get; set; }

        [Required]
        [StringLength(50)]
        public string P_Class { get; set; }
    }
}
