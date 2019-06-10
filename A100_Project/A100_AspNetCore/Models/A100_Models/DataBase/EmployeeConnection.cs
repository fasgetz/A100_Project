using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class EmployeeConnection
    {
        public int EmployeeConnectionKey { get; set; }
        public int Ekey { get; set; }
        public string UserKey { get; set; }
        public bool? Enabled { get; set; }
        public DateTime? ExperyDate { get; set; }
    }
}
