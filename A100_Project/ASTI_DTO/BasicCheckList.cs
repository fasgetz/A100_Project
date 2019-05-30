namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public partial class BasicCheckList
    {
        public BasicCheckList()
        {
            Photomaterial = new HashSet<Photomaterial>();
        }

        public int BasicCheckListID { get; set; }

        public int BasicDamageID { get; set; }

        public int SpecificationsID { get; set; }

        public int? ResoultID { get; set; }

        public int? TransformRow { get; set; }

        public byte[] Photo { get; set; }

        public virtual BasicDamage BasicDamage { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }

        public virtual ICollection<Photomaterial> Photomaterial { get; set; }
    }
}
