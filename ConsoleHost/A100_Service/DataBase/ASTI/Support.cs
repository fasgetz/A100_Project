namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Support")]
    public partial class Support
    {
        public int EmployeeID { get; set; }

        public int SupportID { get; set; }

        [Required]
        [StringLength(250)]
        public string Question { get; set; }

        [StringLength(500)]
        public string Answer { get; set; }

        public DateTime Data { get; set; }

        public int? OutTime { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
