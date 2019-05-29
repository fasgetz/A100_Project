namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StillageType")]
    public partial class StillageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StillageType()
        {
            Specifications = new HashSet<Specifications>();
        }

        public int StillageTypeID { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        public int? DeviationFactor { get; set; }

        public int? DeviationFactorLoaded { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specifications> Specifications { get; set; }
    }
}
