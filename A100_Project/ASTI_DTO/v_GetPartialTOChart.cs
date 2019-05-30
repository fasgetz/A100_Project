namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_GetPartialTOChart
    {
        public int? Green { get; set; }

        public int? Yellow { get; set; }

        public int? Red { get; set; }

        public DateTime PartialTODate { get; set; }

        public int PartialTOID { get; set; }

        public int WarhouseID { get; set; }
    }
}
