namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecificationsElement")]
    public partial class SpecificationsElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecificationsElement()
        {
            StillageTest = new HashSet<StillageTest>();
            StillageTest1 = new HashSet<StillageTest>();
            StillageTest2 = new HashSet<StillageTest>();
            Vik = new HashSet<Vik>();
        }

        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        public int? SpecificationsID { get; set; }

        public int? ResoultID { get; set; }

        public decimal? eH { get; set; }

        public decimal? eB { get; set; }

        public decimal? eL { get; set; }

        public decimal? erb { get; set; }

        public decimal? eA { get; set; }

        public decimal? eC { get; set; }

        public decimal? era { get; set; }

        public int? barType { get; set; }

        [StringLength(50)]
        public string barName { get; set; }

        public decimal? fE { get; set; }

        public decimal? fD { get; set; }

        public int? fLevelCount { get; set; }

        public int? fLevelDistanceMax { get; set; }

        public int? fНLevelLowerMax { get; set; }

        public int? fHLevelLowerMin { get; set; }

        public int? TransformRow { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public short? MaxLoad { get; set; }

        public virtual Element Element { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StillageTest> StillageTest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StillageTest> StillageTest1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StillageTest> StillageTest2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vik> Vik { get; set; }
    }
}
