namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Support
    {
        public int EmployeeID { get; set; }

        public int SupportID { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public DateTime Data { get; set; }

        public int? OutTime { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
