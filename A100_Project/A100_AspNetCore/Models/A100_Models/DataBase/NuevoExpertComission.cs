using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class NuevoExpertComission
    {
        public int NuevoExpertComissionId { get; set; }
        public int EmployeeId { get; set; }
        public string QualificationLevel { get; set; }
        public string CertificationNumber { get; set; }
    }
}
