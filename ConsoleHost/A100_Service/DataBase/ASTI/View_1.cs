namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_1
    {
        public int? Green { get; set; }

        public int? Yellow { get; set; }

        public int? Red { get; set; }

        public int? PartialTOID { get; set; }

        [Key]
        public DateTime PartialTODate { get; set; }
    }
}
