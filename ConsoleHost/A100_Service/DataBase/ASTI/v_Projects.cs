namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_Projects
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarhouseID { get; set; }

        public int? CompanyID { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        public int? CityID { get; set; }

        public int? MetodID { get; set; }

        public DateTime? ControlData { get; set; }

        public int? EmployeeID { get; set; }

        [StringLength(100)]
        public string ProjectNumber { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ControlID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ResoultID { get; set; }

        [StringLength(300)]
        public string ControlName { get; set; }

        [StringLength(200)]
        public string ProjectComment { get; set; }
    }
}
