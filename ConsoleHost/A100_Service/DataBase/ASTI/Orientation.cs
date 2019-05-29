namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orientation")]
    public partial class Orientation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrientationID { get; set; }

        [Column("Orientation")]
        [StringLength(50)]
        public string Orientation1 { get; set; }
    }
}
