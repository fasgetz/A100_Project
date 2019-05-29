namespace A100_Service.DataBase.ASTI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Conclusion")]
    public partial class Conclusion
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
