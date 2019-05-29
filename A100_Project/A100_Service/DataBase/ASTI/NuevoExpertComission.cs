namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NuevoExpertComission")]
    public partial class NuevoExpertComission
    {
        public int NuevoExpertComissionID { get; set; }

        public int EmployeeID { get; set; }

        [Required]
        [StringLength(500)]
        public string QualificationLevel { get; set; }

        [StringLength(300)]
        public string CertificationNumber { get; set; }
    }
}
