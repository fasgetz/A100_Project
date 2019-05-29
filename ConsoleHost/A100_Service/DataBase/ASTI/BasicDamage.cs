namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BasicDamage")]
    public partial class BasicDamage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BasicDamage()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
        }

        public int BasicDamageID { get; set; }

        [StringLength(250)]
        public string BasicDamageName { get; set; }

        public bool IsActual { get; set; }

        [StringLength(1000)]
        public string BasicDamageDescription { get; set; }

        public byte? BasicDamageOrder { get; set; }

        [StringLength(800)]
        public string BasicDamageExt { get; set; }

        [StringLength(1000)]
        public string BasicDamageDescriptionText { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }
    }
}
