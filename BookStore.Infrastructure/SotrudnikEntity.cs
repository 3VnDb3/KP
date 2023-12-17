namespace BookStore.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sotrudnik")]
    public partial class SotrudnikEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string fio { get; set; }

        public long nomertel { get; set; }

        public long iddolzotb { get; set; }

        public virtual DolznostbEntity dolznostb { get; set; }
    }
}
