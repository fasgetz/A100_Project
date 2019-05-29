namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetWork
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ControlID { get; set; }

        public int? WarhouseID { get; set; }

        public DateTime? ControlData { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string InspectionMetod { get; set; }

        public int? ResoultID { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(100)]
        public string ProjectNumber { get; set; }

        [StringLength(300)]
        public string ControlName { get; set; }
    }
}
