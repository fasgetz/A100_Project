using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Resoult
    {
        public Resoult()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
            BoltedJoint = new HashSet<BoltedJoint>();
            ClientSchemePermissions = new HashSet<ClientSchemePermissions>();
            Deviation = new HashSet<Deviation>();
            PartialTo = new HashSet<PartialTo>();
            SpecificationsElement = new HashSet<SpecificationsElement>();
            StillageTest = new HashSet<StillageTest>();
        }

        public int ResoultId { get; set; }
        public int ControlId { get; set; }

        public virtual Control Control { get; set; }
        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }
        public virtual ICollection<BoltedJoint> BoltedJoint { get; set; }
        public virtual ICollection<ClientSchemePermissions> ClientSchemePermissions { get; set; }
        public virtual ICollection<Deviation> Deviation { get; set; }
        public virtual ICollection<PartialTo> PartialTo { get; set; }
        public virtual ICollection<SpecificationsElement> SpecificationsElement { get; set; }
        public virtual ICollection<StillageTest> StillageTest { get; set; }
    }
}
