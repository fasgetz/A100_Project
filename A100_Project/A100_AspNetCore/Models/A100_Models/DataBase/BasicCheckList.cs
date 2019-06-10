using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class BasicCheckList
    {
        public BasicCheckList()
        {
            Photomaterial = new HashSet<Photomaterial>();
        }

        public int BasicCheckListId { get; set; }
        public int BasicDamageId { get; set; }
        public int SpecificationsId { get; set; }
        public int? ResoultId { get; set; }
        public int? TransformRow { get; set; }
        public byte[] Photo { get; set; }

        public virtual BasicDamage BasicDamage { get; set; }
        public virtual Resoult Resoult { get; set; }
        public virtual Specifications Specifications { get; set; }
        public virtual ICollection<Photomaterial> Photomaterial { get; set; }
    }
}
