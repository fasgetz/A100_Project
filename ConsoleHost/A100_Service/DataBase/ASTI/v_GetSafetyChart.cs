namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetSafetyChart
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarhouseID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Date { get; set; }

        [StringLength(100)]
        public string InspectedBy { get; set; }

        [StringLength(100)]
        public string ResponsiblePerson { get; set; }

        public int? OK { get; set; }

        public int? NOK { get; set; }

        public int? NotSelected { get; set; }

        [StringLength(20)]
        public string StrDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SafetyID { get; set; }
    }
}
