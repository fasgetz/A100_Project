namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeConnection")]
    public partial class EmployeeConnection
    {
        [Key]
        public int EmployeeConnectionKey { get; set; }

        public int EKey { get; set; }

        [Required]
        [StringLength(250)]
        public string UserKey { get; set; }

        public bool Enabled { get; set; }

        public DateTime? ExperyDate { get; set; }
    }
}
