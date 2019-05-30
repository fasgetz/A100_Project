namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ReportSeBalka
    {
        public int SpecificationsElementID { get; set; }

        public int? SpecificationsID { get; set; }

        public string ElementName { get; set; }

        public int? ResoultID { get; set; }

        public decimal? eH { get; set; }

        public decimal? eB { get; set; }

        public decimal? eL { get; set; }

        public decimal? eC { get; set; }

        public decimal? erb { get; set; }

        public int? barType { get; set; }
    }
}
