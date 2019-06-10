using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class ExpertCommission
    {
        public int ExpertCommissionId { get; set; }
        public string Post { get; set; }
        public string FullName { get; set; }
        public string QualificationLevel { get; set; }
        public int? EmployeeId { get; set; }
        public string IdentificationFrontSide { get; set; }
        public string IdentificationBackSide { get; set; }
        public string CertificationNumber { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
