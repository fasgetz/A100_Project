namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviationPlateLocation")]
    public partial class DeviationPlateLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeviationPlateLocation()
        {
            Deviation = new HashSet<Deviation>();
        }

        public int DeviationPlateLocationID { get; set; }

        [Required]
        [StringLength(250)]
        public string DeviationPlateLocationName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deviation> Deviation { get; set; }
    }
}
