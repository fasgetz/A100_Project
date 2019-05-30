namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Resoult
    {
        public Resoult()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
            BoltedJoint = new HashSet<BoltedJoint>();
            ClientSchemePermissions = new HashSet<ClientSchemePermissions>();
            Deviation = new HashSet<Deviation>();
            PartialTO = new HashSet<PartialTO>();
            SpecificationsElement = new HashSet<SpecificationsElement>();
            StillageTest = new HashSet<StillageTest>();
        }

        public int ResoultID { get; set; }

        public int ControlID { get; set; }

        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }

        public virtual ICollection<BoltedJoint> BoltedJoint { get; set; }

        public virtual ICollection<ClientSchemePermissions> ClientSchemePermissions { get; set; }

        public virtual Control Control { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }

        public virtual ICollection<PartialTO> PartialTO { get; set; }

        public virtual ICollection<SpecificationsElement> SpecificationsElement { get; set; }

        public virtual ICollection<StillageTest> StillageTest { get; set; }
    }
}
