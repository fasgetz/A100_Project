namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Safety")]
    public partial class Safety
    {
        public int SafetyID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int WarhouseID { get; set; }

        [StringLength(100)]
        public string InspectedBy { get; set; }

        [StringLength(100)]
        public string ResponsiblePerson { get; set; }

        public virtual Safety Safety1 { get; set; }

        public virtual Safety Safety2 { get; set; }

        public virtual Warhouse Warhouse { get; set; }
    }
}
