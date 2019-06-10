using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Photomaterial
    {
        public int PhotomaterialId { get; set; }
        public byte PhotoNumber { get; set; }
        public int? BasicCheckListId { get; set; }
        public byte PhotoTypeId { get; set; }
        public int ResoultId { get; set; }
        public string PhotoСaption { get; set; }
        public byte[] Photo { get; set; }

        public virtual BasicCheckList BasicCheckList { get; set; }
        public virtual PhotoType PhotoType { get; set; }
    }
}
