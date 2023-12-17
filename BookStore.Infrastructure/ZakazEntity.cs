namespace BookStore.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zakaz")]
    public partial class ZakazEntity
    {
        public long id { get; set; }

        public long data { get; set; }

        public long idclienta { get; set; }

        public long iduslugi { get; set; }

        public virtual ClientEntity client { get; set; }

        public virtual UslugiEntity uslugi { get; set; }
    }
}
