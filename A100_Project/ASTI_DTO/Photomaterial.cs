namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;


    public class Photomaterial
    {
        public int PhotomaterialID { get; set; }

        public byte PhotoNumber { get; set; }

        public int? BasicCheckListID { get; set; }

        public byte PhotoTypeID { get; set; }

        public int ResoultID { get; set; }

        public string PhotoСaption { get; set; }

        public byte[] Photo { get; set; }

        public virtual BasicCheckList BasicCheckList { get; set; }

        public virtual PhotoType PhotoType { get; set; }
    }
}
