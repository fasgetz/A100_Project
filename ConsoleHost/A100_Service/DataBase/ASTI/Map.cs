namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Map")]
    public partial class Map
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Map()
        {
            StillageTest = new HashSet<StillageTest>();
        }

        public int MapID { get; set; }

        public int? cIndex { get; set; }

        public decimal? X { get; set; }

        public decimal? Y { get; set; }

        public decimal? Width { get; set; }

        public decimal? Height { get; set; }

        public int? Frame { get; set; }

        public int? Rotation { get; set; }

        public int? Iteration { get; set; }

        [StringLength(100)]
        public string MapUnit { get; set; }

        public int SpecificationsID { get; set; }

        [StringLength(50)]
        public string сLevel { get; set; }

        public int? TransformRow { get; set; }

        public int? EmployeeID { get; set; }

        [StringLength(16)]
        public string Row { get; set; }

        [StringLength(16)]
        public string FrameString { get; set; }

        public byte? ShowMode { get; set; }

        public virtual Specifications Specifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StillageTest> StillageTest { get; set; }
    }
}
