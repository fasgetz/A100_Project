using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Conclusion
    {
        public int ConclusionId { get; set; }
        public int? ResoultId { get; set; }
        public int? TransformRow { get; set; }
        public string ExpertConclusion { get; set; }
        public string TechnicalWriterConclusion { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
