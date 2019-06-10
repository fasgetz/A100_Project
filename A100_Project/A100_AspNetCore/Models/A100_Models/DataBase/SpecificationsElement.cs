using System;
using System.Collections.Generic;

namespace A100_AspNetCore.Models.A100_Models.DataBase
{
    public partial class SpecificationsElement
    {
        public SpecificationsElement()
        {
            StillageTestFrameElement = new HashSet<StillageTest>();
            StillageTestLoadElement = new HashSet<StillageTest>();
            StillageTestStoikaElement = new HashSet<StillageTest>();
            Vik = new HashSet<Vik>();
        }

        public int SpecificationsElementId { get; set; }
        public int? ElementId { get; set; }
        public string ElementSize { get; set; }
        public int? SpecificationsId { get; set; }
        public int? ResoultId { get; set; }
        public decimal? EH { get; set; }
        public decimal? EB { get; set; }
        public decimal? EL { get; set; }
        public decimal? Erb { get; set; }
        public decimal? EA { get; set; }
        public decimal? EC { get; set; }
        public decimal? Era { get; set; }
        public int? BarType { get; set; }
        public string BarName { get; set; }
        public decimal? FE { get; set; }
        public decimal? FD { get; set; }
        public int? FLevelCount { get; set; }
        public int? FLevelDistanceMax { get; set; }
        public int? FНlevelLowerMax { get; set; }
        public int? FHlevelLowerMin { get; set; }
        public int? TransformRow { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public short? MaxLoad { get; set; }

        public virtual Element Element { get; set; }
        public virtual Resoult Resoult { get; set; }
        public virtual Specifications Specifications { get; set; }
        public virtual ICollection<StillageTest> StillageTestFrameElement { get; set; }
        public virtual ICollection<StillageTest> StillageTestLoadElement { get; set; }
        public virtual ICollection<StillageTest> StillageTestStoikaElement { get; set; }
        public virtual ICollection<Vik> Vik { get; set; }
    }
}
