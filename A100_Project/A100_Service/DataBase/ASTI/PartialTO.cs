namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartialTO")]
    public partial class PartialTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartialTO()
        {
            Vik = new HashSet<Vik>();
        }

        public int PartialTOID { get; set; }

        public DateTime PartialTODate { get; set; }

        public int WarhouseID { get; set; }

        [StringLength(100)]
        public string EmployeeName { get; set; }

        public bool? TransformRow { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int ResoultID { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vik> Vik { get; set; }
    }
}
