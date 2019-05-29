namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetRadarSafetyChart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SafetyID { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; }

        public int? OK { get; set; }

        public int? NOK { get; set; }
    }
}
