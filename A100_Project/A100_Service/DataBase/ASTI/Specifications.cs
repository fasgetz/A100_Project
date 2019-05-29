namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specifications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specifications()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
            BoltedJoint = new HashSet<BoltedJoint>();
            Deviation = new HashSet<Deviation>();
            Map = new HashSet<Map>();
            StillageTest = new HashSet<StillageTest>();
            StockElements = new HashSet<StockElements>();
            SpecificationsElement = new HashSet<SpecificationsElement>();
        }

        public int SpecificationsID { get; set; }

        public int? StillageTypeID { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        public int? WarhouseID { get; set; }

        public int? TransformRow { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int? ResoultID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoltedJoint> BoltedJoint { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deviation> Deviation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Map> Map { get; set; }

        public virtual StillageType StillageType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StillageTest> StillageTest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockElements> StockElements { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificationsElement> SpecificationsElement { get; set; }
    }
}
