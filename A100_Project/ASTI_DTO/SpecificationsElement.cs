namespace ASTI_DTO
{
    using System;
    using System.Collections.Generic;

    public class SpecificationsElement
    {
        public SpecificationsElement()
        {
            StillageTest = new HashSet<StillageTest>();
            StillageTest1 = new HashSet<StillageTest>();
            StillageTest2 = new HashSet<StillageTest>();
            Vik = new HashSet<Vik>();
        }

        public int SpecificationsElementID { get; set; }

        public int? ElementID { get; set; }

        public string ElementSize { get; set; }

        public int? SpecificationsID { get; set; }

        public int? ResoultID { get; set; }

        public decimal? eH { get; set; }

        public decimal? eB { get; set; }

        public decimal? eL { get; set; }

        public decimal? erb { get; set; }

        public decimal? eA { get; set; }

        public decimal? eC { get; set; }

        public decimal? era { get; set; }

        public int? barType { get; set; }

        public string barName { get; set; }

        public decimal? fE { get; set; }

        public decimal? fD { get; set; }

        public int? fLevelCount { get; set; }

        public int? fLevelDistanceMax { get; set; }

        public int? fНLevelLowerMax { get; set; }

        public int? fHLevelLowerMin { get; set; }

        public int? TransformRow { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? UpdateTime { get; set; }

        public short? MaxLoad { get; set; }

        public virtual Element Element { get; set; }

        public virtual Resoult Resoult { get; set; }

        public virtual Specifications Specifications { get; set; }

        public virtual ICollection<StillageTest> StillageTest { get; set; }

        public virtual ICollection<StillageTest> StillageTest1 { get; set; }

        public virtual ICollection<StillageTest> StillageTest2 { get; set; }

        public virtual ICollection<Vik> Vik { get; set; }
    }
}
