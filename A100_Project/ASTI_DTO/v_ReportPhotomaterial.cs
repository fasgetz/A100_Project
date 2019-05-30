namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;


    public class v_ReportPhotomaterial
    {

        public string PhotoTypeName { get; set; }

        public int PhotomaterialID { get; set; }

        public string FinalCaption { get; set; }

        public int? BasicCheckListID { get; set; }

        public byte PhotoTypeID { get; set; }

        public int ResoultID { get; set; }

        public byte[] Photo { get; set; }
    }
}
