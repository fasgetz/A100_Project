namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetSafety
    {
        public int SafetyID { get; set; }

        public DateTime Date { get; set; }

        public string CategoryName { get; set; }

        public string CriteriaName { get; set; }

        public int? Status { get; set; }

        public string Comment { get; set; }
    }
}
