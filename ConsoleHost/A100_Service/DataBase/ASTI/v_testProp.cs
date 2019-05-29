namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_testProp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarhouseID { get; set; }

        [StringLength(150)]
        public string WarhouseName { get; set; }

        public int? EllCount { get; set; }

        public int? Yellow { get; set; }

        public int? Red { get; set; }

        public double? propRed { get; set; }

        public double? propRedYel { get; set; }

        [StringLength(100)]
        public string ProjectNumber { get; set; }
    }
}
