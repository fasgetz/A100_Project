namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Control = new HashSet<Control>();
            Support = new HashSet<Support>();
            ExpertCommission = new HashSet<ExpertCommission>();
        }

        public int EmployeeID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(128)]
        public string UserKey { get; set; }

        public byte? PersonnelNumber { get; set; }

        public bool? isClient { get; set; }

        [StringLength(300)]
        public string FullName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control> Control { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Support> Support { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpertCommission> ExpertCommission { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }
    }
}
