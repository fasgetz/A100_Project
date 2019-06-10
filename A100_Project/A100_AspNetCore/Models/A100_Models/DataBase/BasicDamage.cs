using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class BasicDamage
    {
        public BasicDamage()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
        }

        public int BasicDamageId { get; set; }
        public string BasicDamageName { get; set; }
        public bool? IsActual { get; set; }
        public string BasicDamageDescription { get; set; }
        public byte? BasicDamageOrder { get; set; }
        public string BasicDamageExt { get; set; }
        public string BasicDamageDescriptionText { get; set; }

        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }
    }
}
