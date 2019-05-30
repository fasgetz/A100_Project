namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class v_ReportReferenceCheckListAct
    {

        public int BasicCheckListID { get; set; }

        public string BasicDamageName { get; set; }

        public int? ResoultID { get; set; }

        public string CSV { get; set; }

        public string BasicDamageDescription { get; set; }

        public byte? BasicDamageOrder { get; set; }
    }
}
