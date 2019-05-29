namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetElementsLoad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        [StringLength(100)]
        public string ElementSize { get; set; }

        public int? SpecificationsID { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        public int? StillageTypeID { get; set; }

        public short? MaxLoad { get; set; }

        [StringLength(100)]
        public string ElementName { get; set; }

        public int? ResoultID { get; set; }
    }
}
