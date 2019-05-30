namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public partial class VikElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VikElement()
        {
            Vik = new HashSet<Vik>();
        }

        public int StructuralMemberID { get; set; }
        public string StructuralMemberName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vik> Vik { get; set; }
    }
}
