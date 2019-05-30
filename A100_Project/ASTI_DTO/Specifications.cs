namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class Specifications
    {
        public Specifications()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
            BoltedJoint = new HashSet<BoltedJoint>();
            Deviation = new HashSet<Deviation>();
            Map = new HashSet<Map>();
            StillageTest = new HashSet<StillageTest>();
            StockElements = new HashSet<StockElements>();
            SpecificationsElement = new HashSet<SpecificationsElement>();
        }

        public int SpecificationsID { get; set; }

        public int? StillageTypeID { get; set; }

        public string UnitName { get; set; }

        public string ManufacturedStillage { get; set; }

        public int? FrameHeight { get; set; }

        public int? FrameDepth { get; set; }

        public int? WarhouseID { get; set; }

        public int? TransformRow { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int? ResoultID { get; set; }

        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }

        public virtual ICollection<BoltedJoint> BoltedJoint { get; set; }

        public virtual ICollection<Deviation> Deviation { get; set; }

        public virtual ICollection<Map> Map { get; set; }

        public virtual StillageType StillageType { get; set; }

        public virtual ICollection<StillageTest> StillageTest { get; set; }

        public virtual ICollection<StockElements> StockElements { get; set; }

        public virtual Warhouse Warhouse { get; set; }

        public virtual ICollection<SpecificationsElement> SpecificationsElement { get; set; }
    }
}
