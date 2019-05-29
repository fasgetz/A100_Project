namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SafetyListCriteria")]
    public partial class SafetyListCriteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SafetyListCriteria()
        {
            SafetyList = new HashSet<SafetyList>();
        }

        public int SafetyListCriteriaID { get; set; }

        public int SafetyListCategoryID { get; set; }

        [StringLength(100)]
        public string CriteriaName { get; set; }

        public byte? IsCriteria { get; set; }

        public byte? CriteriaOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SafetyList> SafetyList { get; set; }

        public virtual SafetyListCategory SafetyListCategory { get; set; }
    }
}
