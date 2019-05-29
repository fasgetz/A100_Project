namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetDamage
    {
        public int? WarhouseID { get; set; }

        public int? ResoultID { get; set; }

        [StringLength(100)]
        public string UnitName { get; set; }

        [StringLength(100)]
        public string ManufacturedStillage { get; set; }

        [StringLength(203)]
        public string element { get; set; }

        public int? Green { get; set; }

        public int? Yellow { get; set; }

        public int? Red { get; set; }

        public int? Сorrected { get; set; }

        [StringLength(100)]
        public string StillageTypeName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SpecificationsID { get; set; }

        public int? ElementID { get; set; }

        public int? ElementCount { get; set; }
    }
}
