namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class NuevoExpertComission
    {
        public int NuevoExpertComissionID { get; set; }

        public int EmployeeID { get; set; }

        public string QualificationLevel { get; set; }

        public string CertificationNumber { get; set; }
    }
}
