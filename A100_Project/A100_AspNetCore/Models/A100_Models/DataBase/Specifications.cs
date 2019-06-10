using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class Specifications
    {
        public Specifications()
        {
            BasicCheckList = new HashSet<BasicCheckList>();
            BoltedJoint = new HashSet<BoltedJoint>();
            Deviation = new HashSet<Deviation>();
            Map = new HashSet<Map>();
            SpecificationsElement = new HashSet<SpecificationsElement>();
            StillageTest = new HashSet<StillageTest>();
            StockElements = new HashSet<StockElements>();
        }

        public int SpecificationsId { get; set; }
        public int? StillageTypeId { get; set; }
        public string UnitName { get; set; }
        public string ManufacturedStillage { get; set; }
        public int? FrameHeight { get; set; }
        public int? FrameDepth { get; set; }
        public int? WarhouseId { get; set; }
        public int? TransformRow { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? ResoultId { get; set; }

        public virtual StillageType StillageType { get; set; }
        public virtual Warhouse Warhouse { get; set; }
        public virtual ICollection<BasicCheckList> BasicCheckList { get; set; }
        public virtual ICollection<BoltedJoint> BoltedJoint { get; set; }
        public virtual ICollection<Deviation> Deviation { get; set; }
        public virtual ICollection<Map> Map { get; set; }
        public virtual ICollection<SpecificationsElement> SpecificationsElement { get; set; }
        public virtual ICollection<StillageTest> StillageTest { get; set; }
        public virtual ICollection<StockElements> StockElements { get; set; }
    }
}
