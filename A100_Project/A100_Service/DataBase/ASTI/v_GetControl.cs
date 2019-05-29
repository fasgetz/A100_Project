namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetControl
    {
        [StringLength(100)]
        public string InspectionMetod { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ControlData { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [StringLength(100)]
        public string ProjectNumber { get; set; }

        public int? WarhouseID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        [StringLength(300)]
        public string ControlName { get; set; }

        [StringLength(200)]
        public string ProjectComment { get; set; }

        public int? MetodID { get; set; }

        public int? ParentRID { get; set; }
    }
}
