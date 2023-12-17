namespace BookStore.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("uslugi")]
    public partial class UslugiEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UslugiEntity()
        {
            zakaz = new HashSet<ZakazEntity>();
        }

        public long id { get; set; }

        [StringLength(2147483647)]
        public string name { get; set; }

        public int numberBooks { get; set; }
        public int placeInTop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZakazEntity> zakaz { get; set; }
    }
}
