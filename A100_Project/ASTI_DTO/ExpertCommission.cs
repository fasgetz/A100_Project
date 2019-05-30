namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class ExpertCommission
    {
        public int ExpertCommissionID { get; set; }

        public string Post { get; set; }

        public string FullName { get; set; }

        public string QualificationLevel { get; set; }

        public int? EmployeeID { get; set; }

        public string IdentificationFrontSide { get; set; }

        public string IdentificationBackSide { get; set; }

        public string CertificationNumber { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
