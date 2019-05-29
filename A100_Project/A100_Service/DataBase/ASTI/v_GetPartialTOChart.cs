namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_GetPartialTOChart
    {
        public int? Green { get; set; }

        public int? Yellow { get; set; }

        public int? Red { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime PartialTODate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartialTOID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WarhouseID { get; set; }
    }
}
