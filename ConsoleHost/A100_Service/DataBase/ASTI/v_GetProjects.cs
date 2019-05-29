namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetProjects
    {
        public int? WarhouseID { get; set; }

        public DateTime? ControlData { get; set; }

        [StringLength(250)]
        public string UserKey { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        public DateTime? ExperyDate { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool Enabled { get; set; }

        [StringLength(100)]
        public string ProjectNumber { get; set; }

        public int? MetodID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string UserName { get; set; }

        [StringLength(300)]
        public string ControlName { get; set; }

        [StringLength(200)]
        public string ProjectComment { get; set; }
    }
}
