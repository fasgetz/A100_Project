namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExpertCommission")]
    public partial class ExpertCommission
    {
        public int ExpertCommissionID { get; set; }

        [StringLength(50)]
        public string Post { get; set; }

        [StringLength(250)]
        public string FullName { get; set; }

        [StringLength(250)]
        public string QualificationLevel { get; set; }

        public int? EmployeeID { get; set; }

        [StringLength(250)]
        public string IdentificationFrontSide { get; set; }

        [StringLength(250)]
        public string IdentificationBackSide { get; set; }

        [StringLength(250)]
        public string CertificationNumber { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
