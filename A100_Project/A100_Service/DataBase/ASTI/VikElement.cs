namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VikElement")]
    public partial class VikElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VikElement()
        {
            Vik = new HashSet<Vik>();
        }

        [Key]
        public int StructuralMemberID { get; set; }

        [StringLength(50)]
        public string StructuralMemberName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vik> Vik { get; set; }
    }
}
