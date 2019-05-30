namespace ASTI_DTO
{
    using System;

    public class Conclusion
    {
        public int ConclusionID { get; set; }

        public int? ResoultID { get; set; }

        public int? TransformRow { get; set; }

        public string ExpertConclusion { get; set; }

        public string TechnicalWriterConclusion { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
