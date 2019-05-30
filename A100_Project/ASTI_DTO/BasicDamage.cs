namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class BasicDamage
    {
        public BasicDamage()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
        }

        public int BasicDamageID { get; set; }

        public string BasicDamageName { get; set; }

        public bool IsActual { get; set; }

        public string BasicDamageDescription { get; set; }

        public byte? BasicDamageOrder { get; set; }

        public string BasicDamageExt { get; set; }

        public string BasicDamageDescriptionText { get; set; }

        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }
    }
}
