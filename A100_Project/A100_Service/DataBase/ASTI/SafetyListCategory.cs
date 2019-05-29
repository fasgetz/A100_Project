namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SafetyListCategory")]
    public partial class SafetyListCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SafetyListCategory()
        {
            SafetyListCriteria = new HashSet<SafetyListCriteria>();
        }

        public int SafetyListCategoryID { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }

        public int WarhouseID { get; set; }

        public int? CategoryOrder { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SafetyListCriteria> SafetyListCriteria { get; set; }
    }
}
