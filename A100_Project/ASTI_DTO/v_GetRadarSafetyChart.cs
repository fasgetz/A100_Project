namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetRadarSafetyChart
    {
        public int SafetyID { get; set; }

        public string CategoryName { get; set; }

        public int? OK { get; set; }

        public int? NOK { get; set; }
    }
}
