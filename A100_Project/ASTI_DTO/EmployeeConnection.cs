namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class EmployeeConnection
    {
        public int EmployeeConnectionKey { get; set; }

        public int EKey { get; set; }

        public string UserKey { get; set; }

        public bool Enabled { get; set; }

        public DateTime? ExperyDate { get; set; }
    }
}
