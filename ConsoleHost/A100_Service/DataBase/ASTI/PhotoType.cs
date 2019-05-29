namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhotoType")]
    public partial class PhotoType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhotoType()
        {
            Photomaterial = new HashSet<Photomaterial>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte PhotoTypeID { get; set; }

        [Required]
        [StringLength(250)]
        public string PhotoTypeName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photomaterial> Photomaterial { get; set; }
    }
}
