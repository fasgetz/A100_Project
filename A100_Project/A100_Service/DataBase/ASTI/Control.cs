namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Control")]
    public partial class Control
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Control()
        {
            Resoult = new HashSet<Resoult>();
            ControlEmployees = new HashSet<ControlEmployees>();
            ControlProgram = new HashSet<ControlProgram>();
        }

        public int ControlID { get; set; }

        public int? WarhouseID { get; set; }

        public int? MetodID { get; set; }

        public DateTime? ControlData { get; set; }

        public int? EmployeeID { get; set; }

        public int? SecondEmployee { get; set; }

        [StringLength(100)]
        public string ProjectNumber { get; set; }

        [StringLength(100)]
        public string EmployeesList { get; set; }

        [StringLength(300)]
        public string Foundation { get; set; }

        [StringLength(500)]
        public string ContactPersonData { get; set; }

        [StringLength(300)]
        public string ClientDocuments { get; set; }

        public DateTime? ControlEndData { get; set; }

        [StringLength(30)]
        public string DirectiveNumber { get; set; }

        [StringLength(300)]
        public string ControlName { get; set; }

        [StringLength(200)]
        public string ProjectComment { get; set; }

        [StringLength(100)]
        public string ParentProjectNumber { get; set; }

        public int? ParentRID { get; set; }

        public int? ReportDirector { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ControlMetod ControlMetod { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resoult> Resoult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlEmployees> ControlEmployees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlProgram> ControlProgram { get; set; }
    }
}
