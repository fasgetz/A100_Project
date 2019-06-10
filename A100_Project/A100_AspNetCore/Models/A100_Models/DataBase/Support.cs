using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Support
    {
        public int EmployeeId { get; set; }
        public int SupportId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime Data { get; set; }
        public int? OutTime { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
