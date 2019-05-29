namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckListCriteria")]
    public partial class CheckListCriteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckListCriteria()
        {
            CheckList = new HashSet<CheckList>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CheckListCriteriaID { get; set; }

        [Required]
        [StringLength(180)]
        public string CriteriaName { get; set; }

        public bool IsActual { get; set; }

        public bool IsTilesMultiSelect { get; set; }

        public byte? CriteriaOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckList> CheckList { get; set; }
    }
}
