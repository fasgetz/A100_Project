namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ControlProgramElement")]
    public partial class ControlProgramElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlProgramElement()
        {
            ControlProgram = new HashSet<ControlProgram>();
        }

        public int ControlProgramElementID { get; set; }

        [StringLength(80)]
        public string ControlProgramName { get; set; }

        [StringLength(250)]
        public string ControlProgramDescrption { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlProgram> ControlProgram { get; set; }
    }
}
