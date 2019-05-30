namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetSafetyChart
    {
        public int WarhouseID { get; set; }

        public DateTime Date { get; set; }

        public string InspectedBy { get; set; }

        public string ResponsiblePerson { get; set; }

        public int? OK { get; set; }

        public int? NOK { get; set; }

        public int? NotSelected { get; set; }

        public string StrDate { get; set; }

        public int SafetyID { get; set; }
    }
}
